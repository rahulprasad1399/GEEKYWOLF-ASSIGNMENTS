using System;
using System.Collections.Generic;
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
            int max;
            int min;
            int[] num = { 1, 5, 3, 2 };

            program.FindMaxMin(num, out max, out min);
            Console.WriteLine("Maximum number : "+max);
            Console.WriteLine("Minimum number : "+min);
            
        }
        public void FindMaxMin(int[] arr, out int max, out int min)
        {
            int tempMax = arr[0];
            int tempMin = arr[0];
            foreach (int i in arr)
            {
                tempMax = Math.Max(tempMax, i);

                tempMin = Math.Min(tempMin, i);

            }

            max = tempMax;
            min = tempMin;

        }
    }
}
