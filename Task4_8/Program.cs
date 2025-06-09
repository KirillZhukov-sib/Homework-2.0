using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое натуральное число");
            int a = Convert.ToInt32(Console.ReadLine());

            int a1 = a;

            int a2 = a;

            int f = 1;

            while (a1 > 9) { a1 = a1 / 10; f++; }

            int z = 1;
            int a3;

            Console.WriteLine("Ваше число с зеркально отраженными цифрами:");
            while (z <= f)
            {
                int d1 = 1;
                if (z == 1) { d1 = 0; } else { d1 = 1; }

                z++; a2 = a2 / (int)(Math.Pow(10, d1)); a3 = a2 % 10; Console.Write(a3);
            }

        }
    }
}
