using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintNumbers(num);
        }
        static void PrintNumbers(int[] num, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i]);
                }
            }
            else
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    Console.Write(num[i]);
                }
            }

        }
    }
}
