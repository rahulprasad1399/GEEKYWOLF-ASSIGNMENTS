using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BankingConsoleApp.Data
{
    public class BankingAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BankingAppDb;User Id=sa;Password=Rahul@123;TrustServerCertificate=True;");
        }

        public DbSet<Customer> Customers { get; set; }
    }  
}
