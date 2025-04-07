using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class OddEvenList
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            Console.WriteLine("Cúantos números quieres que se organicen?");
            int numAmount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numAmount; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);                
                }
             }

            Console.WriteLine();
            Console.WriteLine("The even numbers are: ");
            Console.WriteLine();

            foreach (int i in even)
            {
                Console.Write($"{i} ");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The odd numbers are: ");
            Console.WriteLine();
            foreach(int i in odd)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }   



    }
}
