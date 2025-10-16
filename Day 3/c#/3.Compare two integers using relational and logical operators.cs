using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class RelationalAndLogicalOperators
    {
        static void main(string[] args)
        {
            int a = 10;
            int b = 20;
            // Relational Operators
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            // Logical Operators

            Console.WriteLine(a > b && b > a);
            Console.WriteLine(a < b || b > a);
        }

    }
}
