using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Напишите первое число");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Напишите второе число");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Напишите какую операцию хотите выполнить с цифрами:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");
                int z = Convert.ToInt32(Console.ReadLine());

                double result = Count(x, y, z);
                Console.WriteLine("Ответ: {0:0.00}", result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на ноль");
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Введено не число");
            }
        }

        static double Count(double x, double y, int z)
        {
            switch (z)
            {
                case 1: return x + y;
                case 2: return x - y;
                case 3: return x * y;
                case 4:
                    if (y == 0) throw new DivideByZeroException();
                    return x / y;
                default: throw new ArgumentException("Неверный код операции");

            }
        }
    }
}
