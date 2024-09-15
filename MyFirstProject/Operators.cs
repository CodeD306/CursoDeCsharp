using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int age = 14;
            float x = 1;
            string helloWorld = "Hello";

            age = age + 1;
            age += 1;
            age++;
            Console.WriteLine(age);
            
            age = age - 1;
            age -= 1;
            age--;
            Console.WriteLine(age);

            x *= 5;
            x /= 6;
            Console.WriteLine(x);
            x = 100;
            Console.WriteLine(x % 90);

            helloWorld += "World";
            Console.WriteLine(helloWorld);



            Console.ReadLine();
        }
    }
}
 8