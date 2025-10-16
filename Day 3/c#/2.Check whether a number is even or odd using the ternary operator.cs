using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class EvenOrOdd
    {
        static void Main(string[] args)
        {
            EvenOrOdd evenOrOdd = new EvenOrOdd();
            bool result = evenOrOdd.CheckEvenOrOdd(7);
            Console.WriteLine(result ? "Even" : "Odd");
        }
        public bool CheckEvenOrOdd(int number)
        {
            return number % 2 == 0;
        }
    }
}
