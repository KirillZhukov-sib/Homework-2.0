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

        }
    }


    public class Building
    {
        private string _adress;
        private double _area;
        private int _yearbuilt;

        public string built (get;set)

        public Building(string adress, double area, int yearbuilt)
        {
            this._adress = adress;
            this._area = area;
            this._yearbuilt = yearbuilt;
        }

        public virtual void Calculatetax(double tax )
        { tax = _area * 1000; }

        public virtual void Displayinfo(double tax)
        { Console.WriteLine(_adress, _area, _yearbuilt); }




    }
}
}















}

