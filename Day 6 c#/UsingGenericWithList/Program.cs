namespace UsingGenericWithList
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            UsingGenerics usingGenerics = new UsingGenerics();
            usingGenerics.AddMark(78);
            usingGenerics.AddMark(92);
            usingGenerics.AddMark(67);
            usingGenerics.AddMark(88);
            usingGenerics.AddMark(95);

            usingGenerics.AverageMark();
            usingGenerics.SortMark(); 
            usingGenerics.RemoveLowestMark();

            usingGenerics.DisplayMarks();
        }
    }

    public class UsingGenerics
    {
        public List<int> marks = new List<int>();
        public double averageMark = 0;
        public void AddMark(int mark)
        {
            marks.Add(mark);
        }

        public void AverageMark()
        {
            averageMark = marks.Average();
            Console.WriteLine("Average Mark : "+ averageMark);
        }

        public void DisplayMarks()
        {
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
        }

        public void SortMark()
        {
            marks.Sort();
        }

        public void RemoveLowestMark()
        {
            int lowestMark = marks.Min();
            marks.Remove(lowestMark);
        }
    }
}
