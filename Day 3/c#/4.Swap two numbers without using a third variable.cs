using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class SwapNumbers
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            SwapNumbers swapNumbers = new SwapNumbers();
            swapNumbers.Swap(num1, num2);
        }
        public void Swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("num1 : " + num1 + "\nnum2 : " + num2);
        }
    }
}
