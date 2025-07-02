using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.WriteLine("Введите имя персонажа");
            string player = Console.ReadLine();
            Console.WriteLine($"Битва начинается! {player} против Злобный Гоблин");


        }
    }

    public class Player : Character
    {
        public Player() { }
    }
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public bool isAlive { get; }

        public Character(string name, int health, int damage)
        {
            Name = name; Health = health; Damage = damage;
        }

        public virtual int Attack()
        {
            return Health - Damage;
        }
    }

}
