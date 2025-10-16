using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class School
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Rahul", 18);
            student.Display();
        }

    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Display()
        {
            Console.WriteLine("Name : " + Name + "\nAge : " + Age);
        }
    }
}
