using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods; // Importing Extension Methods from Other Class File

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Methods";            
            int i = s.WordCount(); // First Extension Method
            bool result = i.IsGreaterThan(25); // Second Extension Method
            Console.WriteLine(string.Format("Word Count of String is:- {0}",i));
            Console.WriteLine(string.Format("Is it exceeding the limit of '25':- {0}",result));

            Console.ReadKey();
        }
    }
}