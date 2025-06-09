using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 20 до 60, включительно");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 20 || a > 60)
            {
                Console.WriteLine("Введите число от 20 до 60, включительно");
                a = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Молодец!");
        }
    }
}
