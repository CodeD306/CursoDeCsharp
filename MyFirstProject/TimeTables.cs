using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class TimeTables
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Di un número");
            Console.WriteLine();

            string numTxt = Console.ReadLine();
            int num = Convert.ToInt32(numTxt);
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("{0} X {1} = {2}", i, num, num * i);
            }

            Console.ReadLine();
        }
    }
}
