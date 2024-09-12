using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class NumericDataTypes
    {
        static void Main(string[] args)
        {
            int x,
                y,
                z;

            int number = 14;
            long bigNumber = 99999l;
            float floatNumber = 1.0f;
            double doubleNumber = 1000000.1d;
            decimal decimalNumber = 1.99m;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(decimalNumber);

            Console.ReadLine();
        }
    }
}
