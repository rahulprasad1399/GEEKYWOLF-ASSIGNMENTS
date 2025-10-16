using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            MyProgram program = new MyProgram();
            int sum;
            double avg;
            program.GetSumAndAverage(5, 10, out sum, out avg);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
        public void GetSumAndAverage(int a, int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = (a + b) / 2;
        }
    }
}
