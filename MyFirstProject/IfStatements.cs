using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class IfStatements
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("¿Cúantos años tienes?");
            Console.WriteLine();

            string textAge = Console.ReadLine();
            int age = Convert.ToInt32(textAge);

            
            if (age <= 0 || age >= 150)
            {
                Console.WriteLine("Esa no puede ser tu edad");
            }
            else if (age >= 19)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
            
            Console.ReadLine();
        }
    }
}
