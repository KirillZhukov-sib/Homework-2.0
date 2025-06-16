using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int b = 5;
            int[] a = {9,0,5,3,8};
            

            for (int i = 0; i < b; i++)
            {
                
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



            Console.WriteLine();
            Console.WriteLine($"Первое наибольшее число ряда {max}  {indm}");
            Console.WriteLine($"Второе наибольшее число ряда {max2}  {indm2}");
        }
    }
}
