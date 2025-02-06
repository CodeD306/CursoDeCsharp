using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class SwitchStatements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un día de la semana usando los números del 1 al 7");
            string weekDaysTxt = Console.ReadLine();
            int weekDays = Convert.ToInt32(weekDaysTxt);

            switch(weekDays) 
            { 
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Dómingo");
                    break;
                default:
                    Console.WriteLine("Resultado inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
