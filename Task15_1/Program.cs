using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int name = a.GetHashCode();
            Console.WriteLine(name);

        }
    }
}
