using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int b = 10;
            const int h = 5;
            int[,] a = new int[b, h];
            Random r = new Random();

            for (int i = 0; i < b; i++)
            {
                int max = a[i, 0];

                for (int j = 0; j < h; j++)
                {
                    a[i, j] = r.Next(0, 11);
                    Console.Write($"{a[i, j], 4}");

                    if (a[i, j] > max)
                        max = a[i, j];
                }
                Console.Write($"  Максимальная цифра строки {max}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
