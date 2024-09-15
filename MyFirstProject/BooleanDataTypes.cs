using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class BooleanDataTypes
    {
        static void Main(string[] args)
        {
           // Un booleano asignado a true
            
            bool gender = true;

            // Si en bool es true sale la respuesta "He is male"

            if (gender)
            {
                Console.WriteLine("He is male");
            }
            else
            {
                Console.WriteLine("She is female");
            }

            gender = false;

            //Pero si es false sale "She is female"

            if (gender)
            {
                Console.WriteLine("He is male");
            }
            else
            {
                Console.WriteLine("She is female");
            }
           
            
            Console.ReadLine();
        }
    }
}
