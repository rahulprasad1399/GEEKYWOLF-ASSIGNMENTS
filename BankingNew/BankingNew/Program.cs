using BankingNew.Data;
using BankingNew.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Diagnostics.Metrics;
using System.IO;

namespace BankingNew
{
    public class BankingNew
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Add New Customer");
            Console.WriteLine("2. View All Customers");
            Console.WriteLine("3. Add or Update Address");
            Console.WriteLine("4. Add New Account");
            Console.WriteLine("5. Delete Account");
            Console.WriteLine("6. Exit");

            bool running = true;

            while (running)
            {
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Customer customer = GetCustomerInput();
                        AccountOperations.AddCustomer(customer);
                        break;
                    case "2":
                        AccountOperations.GetAllCustomers();
                        break;
                    case "3":
                        Console.WriteLine("Enter the id of the customer who you want to change the address");
                        int addressUpdateCustomerId = Convert.ToInt32(Console.ReadLine());
                        AccountOperations.AddOrUpdateAddress(addressUpdateCustomerId);
                        break;
                    case "4":
                        Console.WriteLine("Enter the customer id");
                        int accountAddCustomerId = Convert.ToInt32(Console.ReadLine());
                        Account addAccount = GetAccountInput();
                        AccountOperations.AddAccounts(accountAddCustomerId, addAccount);
                        break;
                    case "5":
                        Console.WriteLine("Enter the customer id : ");
                        int customerId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the account id : ");
                        int accountId = Convert.ToInt32(Console.ReadLine());

                        AccountOperations.DeleteAccount(customerId, accountId);
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Input");
                        break;
                }
            }
        }

        private static Customer GetCustomerInput()
        {
            Console.WriteLine("Enter the FullName : ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter the Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number : ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the date of birth : ");
            string dateOfBirth = Console.ReadLine();

            bool isDobValid = DateTime.TryParse(dateOfBirth, out DateTime dateOfBirthValid);

            Customer customer = new Customer();
            customer.FullName = fullName;
            customer.Email = email;
            customer.PhoneNumber = phoneNumber;

            if (isDobValid)
            {
                customer.DateOfBirth = dateOfBirthValid;
            }

            Address address = GetAddressInput();
            Account account = GetAccountInput();

            customer.Address = address;
            customer.Accounts = new List<Account> { account };

            return customer;
        }

        public static Address GetAddressInput()
        {
            Console.WriteLine("Enter the Street");
            string street = Console.ReadLine();
            Console.WriteLine("Enter the City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the country");
            string country = Console.ReadLine();
            Console.WriteLine("Enter the PostalCode");
            string postalCode = Console.ReadLine();

            Address address = new Address();
            address.Country = country;
            address.Street = street;
            address.City = city;
            address.State = state;
            address.PostalCode = postalCode;

            return address;
        }

        private static Account GetAccountInput()
        {
            Console.WriteLine("Enter the account Number");
            string accountNumber = Console.ReadLine();
            Console.WriteLine("Enter the Balance");
            string balance = Console.ReadLine();

            Account account = new Account();
            account.AccountNumber = accountNumber;

            bool isValidBalance = decimal.TryParse(balance, out decimal balanceValid);

            if (isValidBalance)
            {
                account.Balance = balanceValid;
            }

            return account;
        }
    }

    public class AccountOperations
    {
        public static void AddCustomer(Customer customer)
        {
            BankingAppDbContext context = new BankingAppDbContext();

            context.Add(customer);
            context.SaveChanges();

        }

        public static void GetAllCustomers()
        {
            BankingAppDbContext context = new BankingAppDbContext();
            var customers = context.Customers.Include("Address").Include("Accounts").ToList();

            foreach (var customer in customers)
            {
                string customerInfo = $"{customer.FullName} ";
                string addressInfo = customer.Address != null ? $"{customer.Address.Street},{customer.Address.City},{customer.Address.State},{customer.Address.PostalCode},{customer.Address.Country}" : "";
                string accountInfo = "";
                foreach (var account in customer.Accounts)
                {
                    if (account != null)
                    {
                        accountInfo = $" Account Number : {account.AccountNumber} - Acccount Balance : {account.Balance}";
                    }
                }

                Console.WriteLine(customerInfo + addressInfo + accountInfo);
            }
        }
        public static void AddOrUpdateAddress(int customerId)
        {
            BankingAppDbContext context = new BankingAppDbContext();
            Customer foundCustomer = context.Customers.Include((customer) => customer.Address).FirstOrDefault(customer => customer.Id == customerId);

            Address newAddress = BankingNew.GetAddressInput();

            if (foundCustomer.Address != null)
            {

                foundCustomer.Address.Country = newAddress.Country;
                foundCustomer.Address.Street = newAddress.Street;
                foundCustomer.Address.City = newAddress.City;
                foundCustomer.Address.State = newAddress.State;
                foundCustomer.Address.PostalCode = newAddress.PostalCode;

            }
            else
            {

                Address address = new Address();
                address.Country = newAddress.Country;
                address.Street = newAddress.Street;
                address.City = newAddress.City;
                address.State = newAddress.State;
                address.PostalCode = newAddress.PostalCode;
                address.CustomerId = customerId;

                foundCustomer.Address = address;
            }

            context.SaveChanges();

        }
        public static void AddAccounts(int customerId, Account account)
        {
            BankingAppDbContext context = new BankingAppDbContext();

            Customer foundCustomer = context.Customers.Include("Accounts").FirstOrDefault(customer => customer.Id == customerId);
            if (foundCustomer != null)
            {
                foundCustomer.Accounts.Add(account);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Customer Not Found With the provided Id");
            }

        }

        public static void DeleteAccount(int customerId, int accountId)
        {
            BankingAppDbContext context = new BankingAppDbContext();

            Account accountToDelete = context.Accounts.FirstOrDefault(account => account.Id == accountId && account.CustomerId == customerId);
            if (accountToDelete != null)
            {
                context.Accounts.Remove(accountToDelete);
                context.SaveChanges();
                Console.WriteLine("Account deleted Successfully");
            }
            else
            {
                Console.WriteLine("Unable to find account with the provided accountId and customerId");
            }
        }
    }
}