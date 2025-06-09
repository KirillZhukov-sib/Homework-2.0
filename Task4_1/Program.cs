using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            int n = Convert.ToInt32(Console.ReadLine());

            int s = 1;

            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }

            Console.WriteLine($"Факториал числа {n} равен {s}");
            Console.ReadKey();
        }
    }
}
