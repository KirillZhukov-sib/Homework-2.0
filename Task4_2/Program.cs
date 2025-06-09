using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            double n = Convert.ToInt32(Console.ReadLine());

            double s = 0;

            for (double i = 1; i <= n; i++)
            {
                s += 1 / i;
            }

            Console.WriteLine($"Сумма дробей 1+1/1+1/2+...+1/n равна {s}");
            Console.ReadKey();
        }
    }
}
