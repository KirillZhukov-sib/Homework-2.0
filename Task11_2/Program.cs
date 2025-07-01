using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] airthing = new IFlyable[]
            {
                new Bird (320),
                new Airplane(1800, 541)
            };

            foreach (IFlyable flyable in airthing)
            { flyable.Fly(); }

        }

        public interface IFlyable
        {
            void Fly();
            int MaxAltitude { get; }
        }

        public class Bird : IFlyable
        {
            public int MaxAltitude { get; }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude}");
            }
            public Bird(int altitude)
            { MaxAltitude = altitude; }
        }

        public class Airplane : IFlyable
        {
            public int MaxAltitude { get; }
            public int CountPassanger { get; }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude}, везу {CountPassanger}");
            }
            public Airplane(int altitude, int passanger)
            {
                MaxAltitude = altitude;
                CountPassanger = passanger;
            }
        }
    }
}
