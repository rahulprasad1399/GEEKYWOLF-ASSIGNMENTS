using BankingConsoleApp.AccountOperations;
using BankingConsoleApp.Data;
using BankingConsoleApp.Model;

class Program
{
    static void Main(string[] args)
    {
        //BankingAppDbContext context = new BankingAppDbContext();

        //List<Customer> customers = new List<Customer>
        //{
        //    new Customer
        //    {
        //        Name = "Maria Gonzalez",
        //        Email = "maria.gonzalez@gmail.com",
        //        PhoneNumber = "-1601",
        //        DateOfBirth = new DateTime(1990, 8, 25),
        //        Address = "45 Calle Mayor, Madrid, Spain",
        //        CreatedDate = new DateTime(2025, 2, 15)
        //    },
        //    new Customer
        //    {
        //        Name = "Liam O’Connor",
        //        Email = "liam.oconnor@outlook.com",
        //        PhoneNumber = "-907779",
        //        DateOfBirth = new DateTime(1985, 11, 3),
        //        Address = "89 Abbey Rd, London, UK",
        //        CreatedDate = new DateTime(2025, 3, 10)
        //    },
        //    new Customer
        //    {
        //        Name = "Sophia Müller",
        //        Email = "sophia.mueller@gmail.com",
        //        PhoneNumber = "-2345780",
        //        DateOfBirth = new DateTime(1992, 7, 18),
        //        Address = "22 Berliner Str, Berlin, Germany",
        //        CreatedDate = new DateTime(2025, 4, 5)
        //    },
        //    new Customer
        //    {
        //        Name = "Ethan Brown",
        //        Email = "ethan.brown@yahoo.com",
        //        PhoneNumber = "-1374",
        //        DateOfBirth = new DateTime(1989, 2, 14),
        //        Address = "17 King St, Sydney, Australia",
        //        CreatedDate = new DateTime(2025, 5, 1)
        //    }
        //};

        //context.Customers.AddRange(customers);
        //context.SaveChanges();

        AccountOperations accountOperations = new AccountOperations();
        //accountOperations.AddCustomer("Harry","harry@gmail.com","567", new DateTime(2022, 4, 2), "327 la", new DateTime(2011, 3, 6));
        //accountOperations.UpdateAddress(6, "xyz");
        //accountOperations.DeleteCustomer(8);
        accountOperations.GetAllCustomers();

    }
}