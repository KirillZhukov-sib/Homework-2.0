using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            RectTriangle triangleRect = new RectTriangle();

        }
    }


    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - A) * (p - A));
        }
    }


    class RectTriangle : Triangle
    {

    }
















    class Example
    {
        public string _adress;
        public double _area;
        public int _yearbuilt;


        Example(string adress, double area, int yearbuilt);













    }
}
