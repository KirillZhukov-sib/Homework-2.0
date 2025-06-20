using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");

            string input = Console.ReadLine();

            string phrase = input.ToLower().Replace(" ", "");
            string mirror = "";

            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                mirror += phrase[i];
            }

            if (phrase == mirror)
                Console.WriteLine("Да, ваше выражение является палиндромом");
            else
                Console.WriteLine("Нет ваше выражение не является палиндромом");

            Console.ReadKey();
        }
    }
}
