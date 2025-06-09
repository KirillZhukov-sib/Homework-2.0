using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 натуральных числа");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int s = 1;

            for (int i = 1; i <= b; i++)
            { s = s * a; }

            Console.WriteLine($"Число {a} в степени {b} равно {s}");
            Console.ReadKey();
        }
    }
}
