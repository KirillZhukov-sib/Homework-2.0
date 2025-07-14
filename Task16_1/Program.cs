using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int input = Convert.ToInt32(Console.Readline());

            Task<int[]> task1 = Task.Run(() => Method1(4));
            Task<int> task2 = task1.ContinueWith(t => Method2(t.Result));

            task2.Wait();
            Console.WriteLine(string.Join(" ", task1.Result));
            Console.WriteLine(task2.Result);

        }

        public static int[] Method1(int a)
        {
            Thread.Sleep(1000);
            Random rnd = new Random();
            int[] array = new int[a];

            for (int i = 0; i < a; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
            return array;
        }
        public static int Method2(int[] arr)
        {
            Thread.Sleep(1500);
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            { s += arr[i]; }
            return s / arr.Length;
        }
    }
}