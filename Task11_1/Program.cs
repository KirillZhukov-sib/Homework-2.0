using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] pets = new Animal[]
            {
                new Cat(),
                new Dog()
            };

            foreach (Animal i in pets)
            {
                Console.WriteLine(i.Showinfo());
            }
        }
    }
    public abstract class Animal
    {
        public abstract string name { get; }

        public abstract string Say();

        public string Showinfo()
        { return $"{name} говорит: {Say()}"; }
    }

    public class Cat : Animal
    {
        public override string name => "Кот";
        public override string Say()
        {
            return "Мяу";
        }
    }

    public class Dog : Animal
    {
        public override string name => "Пёс";
        public override string Say()
        {
            return "Гав";
        }
    }


}
