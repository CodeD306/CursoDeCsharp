using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class NumberGuesser
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
            string yourAsnwerTxt = Console.ReadLine();
            int yourAsnwer = Convert.ToInt32(yourAsnwerTxt);


            if (yourAsnwer == answer)
            {
                Console.WriteLine("Es correcto!");
            }
            else
            {
                Console.WriteLine("No es correcto :(");
            }

            Console.ReadLine();
        }
    }
}
