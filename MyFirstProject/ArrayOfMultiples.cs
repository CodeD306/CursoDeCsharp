using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ArrayOfMultiples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Escribe cuantas multiplicaciones quieres que aparezcan");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[length];

            for(int i = 0; i < array.Length; i++) 
            {
                int xNum = num * (i + 1);

                array[i] = xNum;

            }

            foreach (int value in array) 
            {
                Console.Write($"{value} ");
            }

            Console.ReadLine();
        }
    }
}
