using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
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
                a[i] = r.Next(0, 10);
                Console.Write("{0} ", a[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] > a[j])
                    {
                        int z = a[i];
                        a[i] = a[j];
                        a[j] = z;
                    }
                }
            }

            for (int i = 5; i < c; i++)
            {
                for (int j = i + 1; j < c; j++)
                {
                    if (a[i] < a[j])
                    {
                        int z = a[i];
                        a[i] = a[j];
                        a[j] = z;
                    }
                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{a[i]} ");
            }

        }
    }
}
