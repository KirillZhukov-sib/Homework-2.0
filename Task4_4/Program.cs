using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число которое будет возводиться в степень");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите отрицательное натурально число это будет степенью первого числа");
            double b = Convert.ToInt32(Console.ReadLine());

            double s = 1;
            double b1 = b * -1;
            for (double i = 1; i <= b1; i++)
            { s *= a; }
            double c = 1 / s;
            Console.WriteLine($"Число {a} в степени {b} равно {c}");
            Console.ReadKey();
        }
    }
}
