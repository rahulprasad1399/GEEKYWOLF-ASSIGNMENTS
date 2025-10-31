using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter [+] for Addition\nEnter [-] for Subtraction\nEnter [*] for Multiplication\nEnter [/] for Division");
            string oper = Console.ReadLine();

            Console.WriteLine("Enter the first Number");
            string numberString1 = Console.ReadLine();
            bool isValidNumber1 = int.TryParse(numberString1, out int number1);
            if (!isValidNumber1)
            {
                Console.WriteLine("Entered number is invalid");
            }

            Console.WriteLine("Enter the second Number")
            string numberString2 = Console.ReadLine();
            bool isValidNumber2 = int.TryParse(numberString2, out int number2);
            if (!isValidNumber2)
            {
                Console.WriteLine("Enterd number is Invalid");
            }

            Calculator calculator = new Calculator();
            var result = calculator.Operation(oper, number1, number2);
            Console.WriteLine(result);


        }

        public int Operation(string operation, int number1, int number2)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    Console.WriteLine("Enter valid inputs");
                    return 0;
            }
        }
    }
}
