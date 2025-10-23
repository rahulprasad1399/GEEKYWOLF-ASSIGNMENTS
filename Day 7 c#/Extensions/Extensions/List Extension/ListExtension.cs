using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.List_Extension
{
    public static class ListExtension
    {
        public static double AverageExceptZero(this List<int> numbers)
        {
            List<int> nonZeroNumbers = numbers.Where(x => x != 0).ToList();
            return nonZeroNumbers.Average();
        }
    }
}
