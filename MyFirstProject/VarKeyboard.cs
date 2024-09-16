using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class VarKeyboard
    {
        static void Main(string[] args)
        {
           //Var asume que tipo de variable es la seleccionada
            
            var age = 5;
            Console.WriteLine(age);

            var bigNumber = 9000000l;
            Console.WriteLine(bigNumber);

            var name = "David";
            Console.WriteLine(name);

            //Solo debería usarse si es obvio su tipo.

            Console.ReadLine();
        }
    }
}
