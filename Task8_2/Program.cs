using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Укажите свой возраст");
                int age = Convert.ToInt32(Console.ReadLine());
                Validate(age);
                Console.WriteLine("Ваш возраст принят");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не число");
            }
        }

        static void Validate(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 100)
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }

    }

}
