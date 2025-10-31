using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        static void Main(string[] args)
        {
            Employee emp1 = new("Rahul", 12000.00);
        }

        public Employee(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }
        public Employee(string name, double salary) : this(name)
        {
            Salary = salary;
            Console.WriteLine(Name + " " + Salary);
        }
    }
}
