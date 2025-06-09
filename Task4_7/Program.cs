using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            int b = 0;
            if (a == 0)
            {
                Console.WriteLine($"Количество цифр в числе равно {1}");
                Console.ReadKey();
            }
            else
            {
                while (a > 9) { a = a / 10; n++; }
                Console.WriteLine($"Количество цифр в числе равно {n}");
                Console.ReadKey();
            }

        }
    }
}
