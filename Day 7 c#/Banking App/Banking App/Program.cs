using Banking_App;

namespace BankingApp
{ 
    public class Banking{
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(300);
            Console.WriteLine("Savings Balance : " + savingsAccount.GetBalance());

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.Deposit(2000);
            currentAccount.Withdraw(200);
            Console.WriteLine("Current Balance : " + currentAccount.GetBalance());

            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.MakePayment(100);

            UPIPayment upiPayment = new UPIPayment();
            upiPayment.MakePayment(200);

            NetBankingPayment netBankingPayment = new NetBankingPayment();
            netBankingPayment.MakePayment(300);

            //PaymentProcessor paymentProcessor = new PaymentProcessor(new CreditCardPayment());
            //paymentProcessor.MakePayment(500);

            PaymentProcessor paymentProcessor = new PaymentProcessor(new SavingsAccount());
            paymentProcessor.MakePayment(50000);

            Console.WriteLine("Savings Balance : " + savingsAccount.GetBalance());
            Console.WriteLine("Current Balance : " + currentAccount.GetBalance());
        }
    }
}