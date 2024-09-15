using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConvertingStringToNumbers
    {
        static void Main(string[] args)
        {
           //Convierte tipos string en Números
            string textAge = "14";
            int Age = Convert.ToInt32(textAge);
            Console.WriteLine(Age);

            string textBigNumber = "90000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textPi = "3,14";
            float pi = Convert.ToSingle(textPi);
            Console.WriteLine(pi);

            string textBiggerPi = "3,14159265358979323846264";
            double biggerPi = Convert.ToDouble(textBiggerPi);
            Console.WriteLine(biggerPi);

            string textMoney = "14,99";
            decimal Money = Convert.ToDecimal(textMoney);
            Console.WriteLine(Money);

            Console.ReadLine();

        }
    }
}
