using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите поочередно стороны первого треугольника: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите поочередно стороны второго треугольника: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double b3 = Convert.ToDouble(Console.ReadLine());

            if (!Valid(a1, a2, a3) || !Valid(b1, b2, b3))
            {
                Console.WriteLine("Ошибка: один из треугольников не существует!");
                return;
            }

            double square1 = Sqab(a1, a2, a3);
            double square2 = Sqab(b1, b2, b3);

            if (square1 > square2)
            {
                Console.WriteLine("Площадь первого треугольника {0:F2} больше площади второго {1:F2}", square1, square2);
            }
            else if (square2 > square1)
            {
                Console.WriteLine("Площадь второго треугольника {0:F2} больше площади первого {1:F2}", square2, square1);
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника {0:F2} равна площади второго {1:F2}", square1, square2);
            }
        }

        static double Sqab(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Pow((p * (p - x) * (p - y) * (p - z)), 0.5);
        }

        static bool Valid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

    }
}
