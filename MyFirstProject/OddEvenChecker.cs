using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class OddEvenChecker
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;

            if (remainder == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadLine();
        }
    }
}
