using System.Collections;

namespace ArrayListOperations
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            // Adding students to the list 
            ArrayListOperations operations = new ArrayListOperations();
            operations.AddStudents("Thomas Shelby");
            operations.AddStudents("Arthur Shelby");
            operations.AddStudents("John Shelby");
            operations.AddStudents("Ada Shelby");
            operations.AddStudents("Polly Gray");

            // To remove a student 
            operations.RemoveStudents();

            // To insert a student at a particular index 
            operations.InsertStudents(2, "Harry Maguire");

            // To display students 
            operations.DisplayStudents();
        }
    }

    public class ArrayListOperations
    {
        public ArrayList arrayList = new ArrayList();
        public void AddStudents(string studentName)
        {
            arrayList.Add(studentName);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Using foreach loop : ");
            foreach (var student in arrayList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Using for loop : ");
            for (int i=0;i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }

        public void RemoveStudents()
        {
            arrayList.RemoveAt(0);
        }

        public void InsertStudents(int index, string name)
        {
            arrayList.Insert(index, name);
        }

    }
}
