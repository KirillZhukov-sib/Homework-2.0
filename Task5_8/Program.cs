using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            for (int i = 0; i < b; i++)
            {
                a[i] = r.Next(0, 10);
                Console.Write($"{a[i]}  ");
            }

            
            int max = a[0];
            int indm = 0;
            int max2 = a[1];
            int indm2 = 1;


            for (int s = 1; s < b; s++)
            {
                if (a[s] > max)
                {
                    max = a[s];
                    indm = s;
                }

            }

            for (int s = 0; s < b; s++)
            {
                
                if (a[s] > max2 && s!=indm)
                {
                    max2 = a[s];
                    indm2 = s;
                }
                
            }
            
            Console.WriteLine();
            Console.WriteLine($"Первое наибольшее число {max}  {indm}");
            Console.WriteLine($"Второе наибольшее число {max2}  {indm2}");
        }
    }
}
