using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int b = 5;
            int[] a = new int[b];
            Random r = new Random();
            int max = a[0];
            int max2 = a[0];
            for (int i = 0; i < b; i++)
            {
                a[i] = r.Next(0, 11);
                Console.Write($"{a[i]}  ");
            }

            foreach (int j in a) { if (j > max) max = j; };
            foreach (int l in a) { if (l > max2 && l < max) max2 = l; };

            Console.WriteLine();
            Console.WriteLine($"Максимально число ряда {max} и {max2}");
        }
    }
}
