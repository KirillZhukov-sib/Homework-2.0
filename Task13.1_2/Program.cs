using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task13._1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует шифратор-дешифратор");
            Console.WriteLine("Напишите код который вы хотите зашифровать или рашифровать");
            string input = Console.ReadLine();

            char[] alphabet = Enumerable.Range('a', 26).Select(c => (char)c).ToArray();
            char[] ALPHABET = Enumerable.Range('A', 26).Select(c => (char)c).ToArray();


            char[] code = input.ToArray();


            for (int i = 0; i < code.Length; i++)
            {
                int index = Array.IndexOf(alphabet, code[i]);
                int INDEX = Array.IndexOf(ALPHABET, code[i]);

                if (index != -1)
                {
                    code[i] = alphabet[alphabet.Length - index - 1];
                }

                else if (INDEX != -1)
                {
                    code[i] = ALPHABET[ALPHABET.Length - INDEX - 1];
                }
            }
            Console.Write("Ваш зашифрованный или дешифрованный код: ");
            Console.Write(code);
        }
    }
}
