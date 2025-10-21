using DataAccess;

namespace BusinessLogic
{
    public class Manager
    {
        public static List<string> GetAllFromBusinessLogic()
        {
            return Database.GetAllEmployee();
        }
        public static void AddEmployeeFromBusinessLogic(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Enter a valid name");
                return;
            }
            Database.AddEmployee(name);
        }
    }

}