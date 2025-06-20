using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц: ");
            string month = Console.ReadLine();  

            Console.WriteLine("Введите год: ");
            string year = Console.ReadLine();

            Console.WriteLine("Введите общую сумму продаж: ");
            string money = (Console.ReadLine());

            Console.WriteLine("Введите количество проданных товаров: ");
            string product = (Console.ReadLine());

            double avr = Convert.ToDouble(money) / Convert.ToDouble(product);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Отчет о продажах за {0} {1} года",month, year);
            Console.WriteLine("--------------------------------");
            Console.WriteLine(String.Format("Общая сумма продаж {0:N2} р.", Convert.ToDouble(money)));
            Console.WriteLine(String.Format("Количество проданных товаров {0:0,0} шт.", Convert.ToDouble(product)));
            Console.WriteLine(String.Format("Средняя стоимость товаро {0:N2} р.", Convert.ToDouble(avr)));
            
        }
    }
}
