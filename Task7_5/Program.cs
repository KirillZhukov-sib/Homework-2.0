using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 2;
            int a2 = 2;
            double b1 = 2;
            double b2 = 2;

            Console.WriteLine("Ответ {0}", Multiply(a1, a2));
            Console.WriteLine("Ответ {0}", Multiply(b1, b2));
        }


        static int Multiply(int a, int b)
        {
            return a + b;

        }

        static double Multiply(double a, double b)
        {
            return a + b;

        }

    }
}
