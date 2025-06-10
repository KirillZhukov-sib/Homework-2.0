using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int c = 10;
            int[] a = new int[c];
            Random r = new Random();
            int c1 = 0;
            int c2 = 0;

            for (int i = 0; i < c; i++)
            {
                a[i] = r.Next(0, 101);
                Console.Write("{0} ", a[i]);

                if (a[i] % 2 == 0) c2++;
                else c1++;
            }

            Console.WriteLine();
            if (c1 > c2) Console.WriteLine("Нечетных чисел больше");
            else if (c1 < c2) Console.WriteLine("Четных чисел больше");
            else Console.WriteLine("Четных и нечетных чисел поровну");
            Console.ReadKey();
        }
    }
}
