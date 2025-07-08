using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gamers = new List<string>();
            gamers.Add("Иванов");
            gamers.Add("Петров");
            gamers.Add("Сидоров");

            gamers.Insert(1, "Козлов");

            bool Petrov = gamers.Contains("Петров");
            Console.WriteLine($"Есть ли Петров в команде? {Petrov}");

            gamers.Remove("Сидоров");

            Console.WriteLine($"Индекс игрока Козлов: {gamers.IndexOf("Козлов")}");

            gamers.Sort();

            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < gamers.Count; i++)
            {
                Console.WriteLine($"{i}. {gamers[i]}");
            }

            bool empty = gamers.Count == 0;
            Console.WriteLine($"Команда пуcта? - {empty}");

            gamers.Clear();

            Console.WriteLine($"Количество игроков после очистки: {gamers.Count}");

        }
    }


}
