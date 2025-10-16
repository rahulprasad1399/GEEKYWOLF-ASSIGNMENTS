using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MyProgram
    {
        static void Main(string[] args)
        {

            BankAccount account1 = new BankAccount("987654321", "Rohit", 12000);
            account1.Display();
        }
    }
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public int Balance { get; set; }

        public BankAccount()
        {
            AccountHolder = "Rahul";
            Balance = 0;
            AccountNumber = "123456789";
        }
        public BankAccount(string accountNumber, string accountHolder, int balance) : this()
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void AddDeposit(int balance)
        {
            Balance = Balance + balance;
        }

        public void Display()
        {
            Console.WriteLine(AccountHolder + "\n" + AccountNumber + "\n" + Balance);
        }

    }
}
