using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class PaymentProcessor
    {
        //public IPaymentService PaymentService { get; set; }
        //public PaymentProcessor(IPaymentService paymentService)
        //{
        //    PaymentService = paymentService;
        //}

        //public void MakePayment(double amount)
        //{
        //    PaymentService.MakePayment(amount);
        //}

        public IAccount iaccount {  get; set; }

        public PaymentProcessor(IAccount iaccount)
        {
            this.iaccount = iaccount;
        }

        public void MakePayment(double amount)
        {
            iaccount.Deposit(amount);
        }
    }
}
