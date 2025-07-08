using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            tasks.Add("Помыть посуду");
            tasks.Add("Купить продукты");
            tasks.Add("Покорпить кота");

            tasks.Insert(1, "Сделать зарятку");

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }

            bool cats = tasks.Contains("Покормить кота");
            Console.WriteLine($"Если задача {cats}");



        }


    }


}
