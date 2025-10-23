using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public interface IAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();
    }
}
