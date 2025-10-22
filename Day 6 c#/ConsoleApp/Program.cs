using EmployeeManagmentSystem;

namespace consoleApp
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            EmployeeManagment employee = new EmployeeManagment();
            employee.AddEmployee("EMP1001", "Harry", 2000, "Permanent");
            employee.DisplayEmployee();
        }
    }
}
