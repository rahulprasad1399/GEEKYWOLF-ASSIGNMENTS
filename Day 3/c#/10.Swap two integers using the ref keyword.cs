using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Swap
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Swap swap = new Swap();
            swap.SwapNumbers(ref num1, ref num2);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public void SwapNumbers(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
        }
    }
}
