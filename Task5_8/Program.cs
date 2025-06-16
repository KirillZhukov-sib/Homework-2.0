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

            for (int i = 0; i < b; i++)
            {
                a[i] = r.Next(0, 3);
                Console.Write($"{a[i]}  ");
            }


            int max = a[0];
            int indm = 0;
            int max2 = a[0];
            int indm2 = 0;


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
                //if (a[s] > max2 && a[s] != a[indm])
                if (a[s] > max2 && indm != s)
                {
                    max2 = a[s];
                    indm2 = s;
                }

            }












            /* for (int s = 0; s < 4; s++)
             {
                 if (a[s] > max2) { max2 = a[s]; }
             }
            */



            //for (; indmax < c; indmax++) { if (a[indmax] == max) break; }

            //foreach (int j in a) { if (j > max) max = j; };

            //foreach (int l in a) { if (l > max2 && l < max) max2 = l; };

            /*int s = 0;
            for (; s < 4; s++) ;
            {
                if (a[s] > max2) { max2 = a[s]; }
            }
            */

            Console.WriteLine();
            Console.WriteLine($"Первое наибольшее число ряда {max}  {indm}");
            Console.WriteLine($"Второе наибольшее число ряда {max2}  {indm2}");
        }
    }
}
