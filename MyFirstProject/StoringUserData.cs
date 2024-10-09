using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class StoringUserData
    {
        static void Main(string[] args)
        {
            var name = "David";
            var password = "012345";
            var age = 14;

            Console.WriteLine(name);
            Console.WriteLine(password);
            Console.WriteLine(age);
                
            Console.ReadLine();
        }
    }
}
