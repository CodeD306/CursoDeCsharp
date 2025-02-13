using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class TryParseFunction
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dime un número");
            string numTxt = Console.ReadLine();

            int num = 0;

            while (!int.TryParse(numTxt, out num))
            {
                Console.WriteLine();
                Console.WriteLine("Está mal >:(");
                Console.WriteLine();
                Console.WriteLine("Dime un número");
                numTxt = Console.ReadLine();
            }
        }
    }
}
