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
            bool correct = int.TryParse(numTxt, out num);



            while (!correct)
            {
                Console.WriteLine();
                Console.WriteLine("Está mal >:(");
                Console.WriteLine();
                Console.WriteLine("Dime un número");
                numTxt = Console.ReadLine();
                correct = int.TryParse(numTxt, out num);
            }

            if (correct)
            {
                Console.WriteLine();
                Console.WriteLine("Si es " + num);
            }

            Console.ReadLine();
        }
    }
}
