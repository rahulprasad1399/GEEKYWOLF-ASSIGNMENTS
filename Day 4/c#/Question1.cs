using System.Diagnostics;

namespace MyProgram
{
   public class MyProgram
   { 
       static void Main(string[] args)
       {
           EmployeeManagement employee1 = new EmployeeManagement("John Doe", 15000, "Permanent");
           EmployeeManagement employee2 = new EmployeeManagement("Liam Smith", 20000, "Contract");
           EmployeeManagement employee3 = new EmployeeManagement("Mary James", 15000, "Permanent");
            
           Console.WriteLine(employee1.EmployeeDetails());
           Console.WriteLine(employee2.EmployeeDetails());
           Console.WriteLine(employee3.EmployeeDetails());
            
       }
   }
   public class EmployeeManagement
   {
       public string Id { get; private set; }
       private static int IdCounter;
       public string Name { get; set; }
       public double Salary { get; set; }
       public string EmployeeType { get; set; }

       static EmployeeManagement()
       {
           IdCounter = 1000;
       }

       public EmployeeManagement(string name, double salary, string employeeType)
       {
           IdCounter++;
           Id = $"Emp{IdCounter}";
           Name = name;
           Salary = salary;
           EmployeeType = employeeType;
       }

       public static int GetNumOfEmployee()
       {
           return IdCounter - 1000;
       }

       public static string GetNextAvailableId()
       {
           return $"Emp{IdCounter + 1}";
       }

       public string EmployeeDetails()
       {
           return $"Employee Id {Id},Employee Name {Name}, Employee Type {EmployeeType}, Salary {Salary}";
       }
   }
}

