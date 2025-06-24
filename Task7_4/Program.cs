using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 6, 134, 25, 4 };

            Console.WriteLine(FindMax(numbers));
        }

        static int FindMax(params int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            return max;

        }



    }
}
