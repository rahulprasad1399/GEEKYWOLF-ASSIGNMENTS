using MathUtilities.Utils;

namespace MathUtilities
{
    public class Utilities
    {
        static void Main(string[] args)
        {

            Util utils = new Util();

            bool isEven = utils.IsEven(10);
            Console.WriteLine(isEven);

            bool isPrime = utils.IsPrime(10);
            Console.WriteLine(isPrime);

            int fact = utils.Factorial(3); 
            Console.WriteLine(fact);    
        }
    }
}
