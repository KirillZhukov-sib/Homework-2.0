using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите номер");

            string a = Console.ReadLine();

            Regex regex = new Regex(@"^\+\d\(\d{3}\)\d{3}-\d{2}-\d{2}$");


            if (regex.IsMatch(a))
                Console.WriteLine("Номер корректен");
            else
                Console.WriteLine("Номер не корректен");

            Console.ReadLine();

        }
    }
}
