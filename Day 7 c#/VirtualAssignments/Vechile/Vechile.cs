using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechileAssignment
{
    public class Vechile
    {
        public virtual void ShowType()
        {
            Console.WriteLine("This is a Vechile");
        }
    }

    public class Car : Vechile
    {
        public new void ShowType()
        {
            Console.WriteLine("This is a Car");
        }
    }
}
