using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace EmployeeManagmentSystem
{
    public class EmployeeManagment
    {
        List<Employee> employeeList = new List<Employee>();
        public void AddEmployee(string name, double salary, string employeeType)
        {
            Employee employee = new Employee(name, salary, employeeType);
            employeeList.Add(employee);
        }

        public void RemoveEmployee(string id)
        {
            var employee = employeeList.FirstOrDefault(x => x.Id == id);
            if(employee != null)
            {
                employeeList.Remove(employee);
            } else
            {
                Console.WriteLine("No Employee Found with the provided Id");
            }
        }

        public void DisplayEmployee()
        {
            foreach (Employee employee in employeeList) { 
                Console.WriteLine($"Id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}, EmployeeType : {employee.EmployeeType}");
            }
        }

        public void SearchEmployee(string name)
        {
            var employeeFound = employeeList.FirstOrDefault(x => x.Name == name);
            if(employeeFound == null)
            {
                Console.WriteLine("Employee Not Found");
            } else
            {
                Console.WriteLine("Employee Found");
            }
        }
    }

    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string EmployeeType {get; set;}

        public static int Counter = 1000;


        public Employee(string name, double salary, string employeeType)
        {
            Counter++;
            Id = $"Emp"+Counter;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }
    }
}
