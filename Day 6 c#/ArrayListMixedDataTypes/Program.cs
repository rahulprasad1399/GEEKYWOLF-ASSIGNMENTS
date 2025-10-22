using System.Collections;

namespace ArrayListMixedDataTypes
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            MixDataTypes mixdata = new MixDataTypes();
            mixdata.AddStringItem("Harry");
            mixdata.AddIntegerItem(25);
            mixdata.AddDoubleItem(75.5);
            mixdata.AddBoolItem(true);
            mixdata.DisplayItem();
        }
    }

    public class MixDataTypes
    {
        public ArrayList arrayList = new ArrayList();
        public void AddStringItem(string item)
        {
            arrayList.Add(item);
        }
        public void AddIntegerItem(int item)
        {
            arrayList.Add(item);
        }
        public void AddDoubleItem(double item)
        {
            arrayList.Add(item);
        }
        public void AddBoolItem(bool item)
        {
            arrayList.Add(item);
        }
        public void DisplayItem()
        {
            foreach (var item in arrayList) { 
            Console.WriteLine(item+" "+item.GetType());
            }
        }
    }
}
