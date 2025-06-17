using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;
            int[,]a = new int[n,m];
            Random random = new Random();

            for (int i=0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    a[i,j] = random.Next(0,n);
                    Console.Write($"{a}");
                }    
                
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
