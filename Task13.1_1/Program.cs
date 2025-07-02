using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я загадал число от 1 до 100, попробуйте угадать");
            int pn = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int rnd = random.Next(0, 101);
            int attempt = 1;
            while (pn > rnd || pn < rnd)
            {
                attempt++;
                if (pn > rnd) { Console.WriteLine("меньше"); pn = Convert.ToInt32(Console.ReadLine()); }
                else if (pn < rnd) { Console.WriteLine("больше"); pn = Convert.ToInt32(Console.ReadLine()); }
            }
            Console.WriteLine($"Вы молодец угадали число {rnd} за {attempt} попыток");
        }
    }
}
