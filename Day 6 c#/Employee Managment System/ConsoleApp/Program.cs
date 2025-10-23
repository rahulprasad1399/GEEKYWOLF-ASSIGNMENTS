using EmployeeManagmentSystem;

namespace consoleApp
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Management System…");
            Console.WriteLine("Please choose one of the following\n[1]-Add Employee\n[2]-Remove Employee\n[3]-Display All Employees\n[4]-Search Employee\n[5]-Exit");
            int userinput = Convert.ToInt32(Console.ReadLine());
            EmployeeManagment employee = new EmployeeManagment();
            while (userinput != 5)
            {
                switch (userinput)
                {
                    case 1:
                        Console.WriteLine("Employee Name : ");
                        string EmployeeName = Console.ReadLine();
                        Console.WriteLine("Employee Salary : ");
                        int EmployeeSalary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Employee Type it should be either permanent or contract");
                        string EmployeeType = Console.ReadLine();
                        if(EmployeeType.ToLower() == "permanent" || EmployeeType.ToLower() == "contract")
                        {
                            employee.AddEmployee(EmployeeName, EmployeeSalary, EmployeeType);
                        } else
                        {
                            Console.WriteLine("Please Enter a Valid Employee Type");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Employee Id");
                        string EmployeeId = Console.ReadLine();
                        employee.RemoveEmployee(EmployeeId);
                        break;
                    case 3:
                        employee.DisplayEmployee();
                        break;
                    case 4:
                        Console.WriteLine("Enter Name of Employee");
                        string searchEmployee = Console.ReadLine();
                        employee.SearchEmployee(searchEmployee);
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program");
                        return;
                    default:
                        Console.WriteLine("Please Enter a valid Input");
                        break;
                }
                Console.WriteLine("Please choose one of the following\n[1]-Add Employee\n[2]-Remove Employee\n[3]-Display All Employees\n[4]-Search Employee\n[5]-Exit");
                userinput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
