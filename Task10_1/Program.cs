using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task10_1.Building;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building("ул. Семафорная 191", 1324, 1995);
            MultiBuilding b2 = new MultiBuilding("ул.Федора Полетаева", 2341, 1986, 5, true);

            Console.WriteLine("\n1.Информация о первом здании: ");
            b1.Displayinfo();

            Console.WriteLine("\n2.Информация о втором здании: ");
            b2.Displayinfo();

            //Upcasing
            Building b3 = b2;
            Console.WriteLine("\n3. Upcasting - вызов DisplayInfo():");
            b3.Displayinfo();

            //Downcasting 
            if (b3 is MultiBuilding)
            {
                MultiBuilding b4 = (MultiBuilding)b3;
                Console.WriteLine("\n4. Downcasting:");
                Console.WriteLine($"Уникальное свойство: {b4.AreaPerFloor}");
            }

            //Вызов методов 
            Console.WriteLine($"Налог одноэтажного здания {b1.Calculatetax()}");
            Console.WriteLine($"Налог одноэтажного здания {b2.Calculatetax()}");
        }
    }
    public class Building
    {
        private string _adress;
        private double _area;
        private int _yearbuilt;

        public int Buildingage
        {
            get
            {
                int age = DateTime.Now.Year - _yearbuilt;
                return age;
            }
        }

        public Building(string adress, double area, int yearbuilt)
        {
            this._adress = adress;
            this._area = area;
            this._yearbuilt = yearbuilt;
        }

        public virtual double Calculatetax()
        { return _area * 1000; }

        public virtual void Displayinfo()
        {
            Console.WriteLine($"Адрес объекта: {_adress}.");
            Console.WriteLine($"Площадь: {_area} м2.");
            Console.WriteLine($"Возраст строения: {_adress}.");
            Console.WriteLine($"Налог: {Calculatetax()} руб.");
        }



        public sealed class MultiBuilding : Building
        {
            private int _floor;
            private bool _haselevator;


            public MultiBuilding(string adress, double area, int yearbuilt, int floors, bool haselevator)
                : base(adress, area, yearbuilt)
            {
                this._floor = floors;
                this._haselevator = haselevator;
            }

            public override double Calculatetax()
            {
                double basetax = base.Calculatetax();
                double floorcoeff = 1 + (_floor - 1) * 0.05;
                double elevatortax = _haselevator ? 5000 : 0;
                return basetax * floorcoeff + elevatortax;
            }

            public override void Displayinfo()
            {
                base.Displayinfo();
                Console.WriteLine($"Этажность: {_floor}");
                Console.WriteLine($"Наличие лифта: {(_haselevator ? "да" : "нет")}");
                Console.WriteLine($"Площадь на этаж: {AreaPerFloor}");
            }
            public double AreaPerFloor
            { get { return _area / _floor; } }
        }






    }
}