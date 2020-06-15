using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionsMethodClass
    {
        public static bool IsGreaterThan(this int firstValue, int secondValue)
        {
            return firstValue > secondValue;
        }
        public static int WordCount(this String strToBeCalculated)
        {
            return strToBeCalculated.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
