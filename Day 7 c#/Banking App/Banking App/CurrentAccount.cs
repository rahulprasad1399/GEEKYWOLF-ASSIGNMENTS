using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class CurrentAccount : IAccount
    {
        public static double BalanceCurrentAccount { get; set; }
        public void Deposit(double amount)
        {
            BalanceCurrentAccount = BalanceCurrentAccount + amount;
            Console.WriteLine("Current Balance After Deposit : " + BalanceCurrentAccount);
        }

        public double GetBalance()
        {
            return BalanceCurrentAccount;
        }

        public void Withdraw(double amount)
        {
            BalanceCurrentAccount = BalanceCurrentAccount - amount;
            Console.WriteLine("Current Balance After Withdraw : " + BalanceCurrentAccount);
        }
    }
}
