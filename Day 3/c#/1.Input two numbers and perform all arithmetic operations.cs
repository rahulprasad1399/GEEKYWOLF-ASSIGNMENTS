using System.Windows.Markup;

namespace ArithmeticOperations
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            MyProgram result = new MyProgram();
            result.Operation(10, 20);
        }

        public void Operation(int num1, int num2)
        {
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;

            Console.WriteLine("After Performing arithmetic operation : " + sum);
            Console.WriteLine("After Performing subtraction operation : " + sub);
            Console.WriteLine("After Performing multiplication operation : " + mul);
            Console.WriteLine("After Performing Division Operation :" + div);
        }
    }
}
