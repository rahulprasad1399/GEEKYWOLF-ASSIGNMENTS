using BusinessLogic;
using DataAccess;

namespace UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = Manager.GetAllFromBusinessLogic();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Manager.AddEmployeeFromBusinessLogic("Jhon wick");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            List<string> employeefromDatabase = Database.GetAllEmployee();
            foreach (var employee in employeefromDatabase) { Console.WriteLine(employee); }
        }
    }
}
