using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int c = 10;
            int[] a = new int[c];
            Random r = new Random();

            for (int i = 0; i < c; i++)
            {
                a[i] = r.Next(0, 51);
                Console.Write("{0} ", a[i]);
            }

            int max = a[0];
            int min = a[0];
            int indmax = 0;
            int indmin = 0;

            foreach (int j in a) { if (j > max) max = j; };
            foreach (int i in a) { if (i < min) min = i; };

            for (; indmax < c; indmax++) { if (a[indmax] == max) break; }
            for (; indmin < c; indmin++) { if (a[indmin] == min) break; }

            Console.WriteLine();
            Console.WriteLine($"Максимально число в приведенном ряде: {max} находится на месте {indmax}, минимальное значение {min} находится на месте {indmin}");
            Console.ReadKey();
        }
    }
}
