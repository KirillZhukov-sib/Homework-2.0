using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите грань куба");
            double edge = Convert.ToDouble(Console.ReadLine());
            CalcCube(edge, out double v, out double a);
            Console.WriteLine("Куб с гранью {0:F} имеет объем {1:F} кубических единиц и площадь поверхности {2:F} квадратных единиц", edge, v, a);
        }

        static void CalcCube(double a, out double volume, out double surfarea)
        {
            volume = a * a * a;
            surfarea = a * a * 6;
        }
    }

}
