using Extension.List_Extension;
using Extension.String_Extension;

namespace Extensions
{
    public class Extension
    {
        static void Main(string[] args)
        {
            string name = "jon doe";
            Console.WriteLine(name.ToTitleCase());

            List<int> numberList = new List<int>
            {
               10, 0, 20, 30, 0
            };
            Console.WriteLine(numberList.AverageExceptZero());
        }
    }
}
