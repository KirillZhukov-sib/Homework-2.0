using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            string year = Console.ReadLine();

            Console.WriteLine("Введите город: ");
            string town = (Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Имя: {0}, Возраст: {1}, Город: {2}", name, year, town);
            

            Console.WriteLine(Convert.ToString(sb));
            Console.ReadLine();

        }
    }
}
