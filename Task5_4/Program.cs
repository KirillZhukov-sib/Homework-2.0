using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
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
                a[i] = r.Next(0, 50);
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine("");

            for (int j = c - 1; j >= 0; j--)
            {
                Console.Write("{0} ", a[j]);
            }
            Console.ReadKey();

        }
    }
}
