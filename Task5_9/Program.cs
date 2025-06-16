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
            const int size = 10;
            int[] numbers = new int[size];
            Random random = new Random();

            // Заполняем массив случайными числами от 5 до 15
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(5, 16); // Верхняя граница 16 не включается
                Console.Write($"{numbers[i]} ");
            }

            // Находим максимальное значение и его индекс
            int maxValue = numbers[0];
            int maxIndex = 0;

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"\nМаксимальное значение: {maxValue}");
            Console.WriteLine($"Индекс максимального значения: {maxIndex}");
        }
    }
}
