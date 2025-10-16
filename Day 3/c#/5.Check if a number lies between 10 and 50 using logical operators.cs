using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class CheckingNumber
    {
        static void Main(string[] args)
        {
            CheckingNumber number = new CheckingNumber();
            bool result = number.Checking(10);
            Console.WriteLine(result ? "Number lies between 1 and 50" : "Number dosen't lies between 1 and 50");
        }

        public bool Checking(int number)
        {
            return number >= 0 && number <= 50;
        }
    }
}
