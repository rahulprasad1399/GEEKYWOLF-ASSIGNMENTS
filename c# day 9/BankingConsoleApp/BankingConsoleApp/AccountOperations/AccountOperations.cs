using BankingConsoleApp.Data;
using BankingConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp.AccountOperations
{
    public class AccountOperations
    { 
        public string AddCustomer(string name, string email, string phoneNumber, DateTime dateOfBirth, string address, DateTime createdDate)
        {
            
            Customer customer = new Customer();
            customer.Name = name;
            customer.Email = email;
            customer.PhoneNumber = phoneNumber;
            customer.DateOfBirth = dateOfBirth;
            customer.Address = address;
            customer.CreatedDate = createdDate;

            try
            {
                BankingAppDbContext context = new BankingAppDbContext();
                context.Customers.Add(customer);
                context.SaveChanges();
                return "Customer Added Successfully";
            } catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                return "Failed to add customer, please try again";
            }

            
        }

        public string UpdateAddress(int id, string address)
        {
            try{
                BankingAppDbContext context = new BankingAppDbContext();
                var customerFound = context.Customers.FirstOrDefault(customer => customer.Id == id);
                if (customerFound == null)
                {
                    Console.WriteLine("Customer with the provided id dosent exist");
                    return $"Customer with Id : {id} dosen't exist";
                } 
                    customerFound.Address = address;
                    context.SaveChanges();

                return "Customer address updated Successfully";
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Failed to update customer address";
            }
        }

        public string DeleteCustomer(int id)
        {
            try
            {
                BankingAppDbContext context = new BankingAppDbContext();
                var existingCustomer = context.Customers.FirstOrDefault(customer => customer.Id == id);
                context.Customers.Remove(existingCustomer);
                context.SaveChanges();
                return "Deleted customer successfully";
            }catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                return $"${ex.Message}";
            }

        }

        public void GetAllCustomers()
        {
            try
            {
                BankingAppDbContext context = new BankingAppDbContext();
                var customers = context.Customers.ToList(); 
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.Id} {customer.Name} {customer.Email}");
                }
            } catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
