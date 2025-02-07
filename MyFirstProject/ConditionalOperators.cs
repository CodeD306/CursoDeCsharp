using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConditionalOperators
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe tu edad");
            Console.WriteLine();

            string ageTxt = Console.ReadLine();
            int age = Convert.ToInt32(ageTxt);

            string ageCheck = age <= 0 ? "Edad inválida":"Tienes " + age + " años" ;
            Console.WriteLine(ageCheck);

            


            Console.ReadLine();
        }
    }
}
