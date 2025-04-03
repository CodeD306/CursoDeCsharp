using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class PasswordChecker
    {
        static void Main(string[] args)
        {
            string ogPassword = "";
            string password = "";
            int checker = 0;


            while (checker == 0)
            {
                while (ogPassword.Equals(string.Empty) || password.Equals(string.Empty))
                {
                    Console.WriteLine();
                    Console.WriteLine("Write a password");
                    ogPassword = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Write the password again");
                    password = Console.ReadLine();

                    if (ogPassword.Equals(string.Empty) || password.Equals(string.Empty))
                    {
                        Console.WriteLine("Error, write the passwords again");
                        Console.WriteLine();
                    }
                }

                
                if (ogPassword.Length < 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("The passwords are not long enough, write them again");
                    ogPassword = "";
                    password = "";
                }
                
                else if (ogPassword != password)
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("The passwords are not the same, write them again");
                        ogPassword = "";
                        password = "";
                    }
                }
                
                else if (ogPassword == password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Both passwords are the same");
                    checker = 1;
                }
                



            }
        }
    }
}
