using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class NumericFormating
    {
        static void Main(string[] args)
        {

            double num = 15D / 1.53455D;
            Console.WriteLine(string.Format("{0:0.00}", num));
            Console.WriteLine(num.ToString("C"));
            Console.WriteLine(num.ToString("C1"));
            Console.WriteLine(num.ToString("C", CultureInfo.CreateSpecificCulture("eng-US")));

            Console.ReadLine();
        }
    }
}
