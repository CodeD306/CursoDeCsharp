using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class WhileLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el primer número");
            string firstNumberTxt = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberTxt);

            Console.WriteLine("Dime el segundo número");
            string secondNumberTxt = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberTxt);

            int answer = firstNumber * secondNumber;

            Console.WriteLine("¿Cúal es la respuesta de " + firstNumber + " x " + secondNumber);
            string yourAnswerTxt = Console.ReadLine();
            int yourAnswer = Convert.ToInt32(yourAnswerTxt);

            do
            {

                    Console.WriteLine("No es correcto :(");
                    Console.WriteLine();
                    Console.WriteLine("Intentalo denuevo:");
                    yourAnswerTxt = Console.ReadLine();
                    yourAnswer = Convert.ToInt32(yourAnswerTxt);

          
            } while (yourAnswer != answer);
             {
                Console.WriteLine("Es correcto!");
             }


            Console.ReadLine();
        }
    }
}
