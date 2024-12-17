using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConsoleInputOutput
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("¿Como te llamas?");
            Console.WriteLine();

            string name = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Hola " + name + "!");
            
            Console.ReadLine();
        }
    }
}
