using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = 1;

            while (a > b) { a = a / 2; }

            if (a == 1) { Console.WriteLine("Введенное число является стпенью двойки"); } else { Console.WriteLine("Введенное число не является степенью двойки"); }

        }
    }
}
