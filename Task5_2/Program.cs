using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int c = 10;
            int[] a = new int[c];
            Random r = new Random();
            int plus = 0;
            int min = 0;
            int nul = 0;

            for (int i = 0; i < c; i++)
            {
                a[i] = r.Next(-20, 21);
                Console.Write("{0} ", a[i]);

                if (a[i] > 0) plus++;
                else if (a[i] < 0) min++;
                else nul++;
            }
            Console.WriteLine();
            Console.WriteLine($"В указанном ряде чисел положительных чисел {plus}, отрицательных {min}, и нулей {nul}");
            Console.ReadKey();
        }
    }
}
