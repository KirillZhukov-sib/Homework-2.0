using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 1, 2, -3, 4, -5 };

            //удвоение чисел 
            int Double(int x)
            { return x * 2; }
            var result1 = Transform(example, Double);
            Console.WriteLine($"Результат удвоения чисел: {string.Join(", ", result1)}");

            //Возведение в квадрат
            int Pow(int x) { return x * x; }
            var result2 = Transform(example, Pow);
            Console.WriteLine($"Результат возведения в квадрат: {string.Join(", ", result2)}");

            //Замена числа на их модули 
            int Module(int x ) 
            {  return  Math.Abs(x); }
            var result3 = Transform(example, Module);
            Console.WriteLine($"Результат приведения к модулю: {string.Join(", ", result3)}");

        }

        public delegate int Transformer(int a);
        public static int[] Transform(int[] numbers, Transformer transformer)
        {
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = transformer(numbers[i]);
            }
            return result;
        }
    }
}
