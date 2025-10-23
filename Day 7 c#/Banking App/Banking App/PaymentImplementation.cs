using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class CreditCardPayment : IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"{amount} paid via credit card");
        }
    }

    public class UPIPayment : IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"{amount} paid via UPI Payment");
        }
    }

    public class NetBankingPayment : IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"{amount} paid via NetBanking Payment");
        }
    }
}
