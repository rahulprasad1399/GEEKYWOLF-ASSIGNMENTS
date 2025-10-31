using System;

namespace Day3
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            MyProgram program = new MyProgram();
            int max, min;
            int[] num = { 1, 5, 3, 2 };

            program.FindMaxMin(num, out max, out min);
            Console.WriteLine("Maximum number : " + max);
            Console.WriteLine("Minimum number : " + min);
        }

        public void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];

            foreach (var num in arr)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
        }
    }
}
