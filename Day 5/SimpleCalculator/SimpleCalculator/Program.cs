using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCalculator
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first Number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator (+, -, *, /): ");
                string operation = Console.ReadLine();
                int result = 0;

                switch(operation)
                {
                    case "+":
                        result = number1+number2;
                        break;
                    case "-":
                        result = number1-number2;
                        break;
                    case "*":
                        result = number1*number2;
                        break;
                    case "/":
                        result = number1/number2;   
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Operation");
                        break;
                }

                Console.WriteLine($"{number1} {operation} {number2} = {result}");

            } catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine("You Cannot Divide a Number By Zero, Please Try Another Number");
                Console.WriteLine(divideByZeroException.Message);
            } catch (FormatException formatException)
            {
                Console.WriteLine("Input Must Be a Valid Number");
                Console.WriteLine(formatException.Message);
            } catch (OverflowException overflowException)
            {
                Console.WriteLine("Entered Number Isn Too Large To Process");
                Console.WriteLine(overflowException.Message);
            } catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong, Please Try Again Later");
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Operations Completed");
            }
        }
    }
}
