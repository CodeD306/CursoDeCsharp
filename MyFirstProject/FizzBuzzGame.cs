using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class FizzBuzzGame
    {
        static void Main(string[] args)
        {

            bool fiveDiv = false;
            bool threeDiv = false;
            
            
            for (int i = 1; i <= 15; i++)
            {
                fiveDiv = i % 5 == 0;
                threeDiv = i % 3 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.ReadLine();
        }
    }
}
