using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int b = 5;
            const int h = 5;
            int[,] a = new int[b, h];
            
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    a[i, j] = (i+j) % 2 == 0  ? 1 : 0;
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
