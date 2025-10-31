namespace DataAccess
{
    public class Database
    {
        private static List<string> employees = new List<string>
        {
            "Ron",
            "Harry",
            "Hermione"
        };
        public static List<string> GetAllEmployee()
        {
            return employees;
        }

        public static void AddEmployee(string employee) {
            employees.Add(employee);
        }
    }
}
