namespace LINQExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Walter White",
                "Jesse Pinkman",
                "Skyler White",
                "Hank Schrader",
                "Saul Goodman"
            };

            // Names starting with A
            var namesStartingWithA = names.Where(n => n.StartsWith("A")).ToList();

            // Length Greater than 4
            var namesLengthGreaterThan4 = names.Where(n=>n.Length > 11).ToList();
           
        }
    }
}
