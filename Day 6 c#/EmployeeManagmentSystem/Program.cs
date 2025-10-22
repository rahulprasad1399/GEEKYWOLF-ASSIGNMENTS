namespace EmployeeManagmentSystem
{
    public class EmployeeManagment
    {
        List<Employee> employeeList = new List<Employee>();
        public void AddEmployee(string id, string name, double salary, string employeeType)
        {
            Employee employee = new Employee(id, name, salary, employeeType);
            employeeList.Add(employee);
        }

        public void DisplayEmployee()
        {
            foreach (Employee employee in employeeList) { 
                Console.WriteLine(employee.Name);
            }
        }
    }

    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string EmployeeType {get; set;}

        public Employee(string id, string name, double salary, string employeeType)
        {
            Id = id;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }
    }
}
