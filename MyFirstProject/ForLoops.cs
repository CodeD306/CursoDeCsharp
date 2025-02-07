using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ForLoops
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Que quieres escribir?");
            string txt = Console.ReadLine();

            Console.WriteLine("Cuántas veces quieres que se repita?");
            string loopTxt = Console.ReadLine();
            int loopNum = Convert.ToInt32(loopTxt);

            if (loopNum <= 0)
            {
                Console.WriteLine("Número inválido");
            }
            else
            {
                for (int i = 0; i < loopNum; i++)
                {
                    Console.WriteLine(txt);
                }
            }



            Console.ReadLine();
        }
    }
}
