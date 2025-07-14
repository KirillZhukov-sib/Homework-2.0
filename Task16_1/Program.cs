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
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int input = Convert.ToInt32(Console.ReadLine());

            //Задача с использованием продолжения
            Console.WriteLine("Метод с использованием задачи продолжения");
            MethodContinue(input);


            // Задача с использованием asynk/await
            Console.WriteLine("Метод с использованием asynk/await");
            await MethodAsync(input);

            Console.WriteLine("Задачи завершены");
        }

        static void MethodContinue(int input)
        {
            Task<int[]> task1 = Task.Run(() => Method1(input));
            Task<int> task2 = task1.ContinueWith(t => Method2(t.Result));
            Console.WriteLine("Массив: " + string.Join(" ", task1.Result));
            Console.WriteLine("Среднее значение: " + task2.Result);
        }
        static async Task MethodAsync(int input)
        {
            int[] array = await Task.Run(() => Method1(input));
            Console.WriteLine("Массив: " + string.Join(" ", array));

            double average = await Task.Run(() => Method2(array));
            Console.WriteLine("Среднее арифметическое: " + average);
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