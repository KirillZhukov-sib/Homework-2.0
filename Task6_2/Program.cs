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
            //Console.WriteLine("Введите предложение: ");

            //StringBuilder input1 = new StringBuilder("привет А роза упала на лапу Азора пока");
            //StringBuilder input2 = new StringBuilder("привет А роза упала на лапу Азора пока");

            string input = "А роза упала на лапу Азора";

            string input1 = input.ToLower().Replace(" ", "");
            string mirror = input1;

            //for (int i = 0; i < input1.Length; i++)
            //{

            //}
            

            //string input2 = input.Replace(" ","");




            //string[] words = input.Split(' ');
            //string max = words[0];

            //for (int i = 1; i < words.Length; i++)
            //{
            //    if (words[i].Length > max.Length)
            //        max = words[i];
            //}

            Console.WriteLine(input1.Length);
            
            //Console.WriteLine("Самое длинное слово предложения: {0}  ", max);
            Console.ReadKey();
        }
    }
}
