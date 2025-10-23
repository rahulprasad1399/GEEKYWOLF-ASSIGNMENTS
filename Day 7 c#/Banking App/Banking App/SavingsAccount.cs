using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class SavingsAccount : IAccount
    {
        public static double BalanceSavings { get; set; }
        public void Deposit(double amount)
        {
            BalanceSavings = BalanceSavings + amount;
            Console.WriteLine("Savings Balance Amount After the Deposit : " + BalanceSavings);
        }

        public double GetBalance()
        {
            return BalanceSavings;
        }

        public void Withdraw(double amount)
        {
            BalanceSavings = BalanceSavings - amount;
            Console.WriteLine("Savings Balance Amount After the Withdraw : " + BalanceSavings);
        }
    }
}
