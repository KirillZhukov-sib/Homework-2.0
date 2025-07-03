using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task13._1_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("=== Игра 'Битва с монстром' ===");
            Console.WriteLine("Введите имя персонажа");
            string playername = Console.ReadLine();
            Monster monster = new Monster();
            Player player = new Player(playername);

            Console.WriteLine($"Битва начинается {playername} против {monster.Name} ");

            while (monster.isAlive && player.isAlive)
            {
                Console.WriteLine("Ваш ход");
                Console.WriteLine("1 - Атаковать / 2 - Использовать зелье здоровья");

                int move;

                while (!int.TryParse(Console.ReadLine(), out move) || (move != 1 && move != 2))
                {
                    Console.WriteLine("Ошибка! Введите 1 или 2:");
                }

                switch (move)
                {
                    case 1:
                        {
                            Console.WriteLine($"{playername} наносит {player.Damage} урона {monster.Name}");
                            player.Attack(monster);
                            if (!monster.isAlive)
                            { Console.WriteLine($"Это был заключительный бой для {monster.Name}, он мертв!"); }
                            break;
                        }
                    case 2:
                        {
                            player.UsePotion();
                            break;
                        }
                }

                if (monster.isAlive)
                {
                    Console.WriteLine($"Ход {monster.Name}...");
                    monster.Attack(player);
                    Console.WriteLine($"{monster.Name} наносит {monster.Damage} игроку {player.Name}");
                    if (!player.isAlive)
                    { Console.WriteLine($"Это был заключительный бой для {player.Name}, он мертв!"); }

                }
                Console.WriteLine($"Текущее состояние:\n{player.Name}: {player.Health}\n{monster.Name}: {monster.Health}");
            }
            Console.WriteLine("Хотите повторить игру?\nНажмите: 1 - если хотите продожить, 2 - если хотите закончить");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1 && choice != 2) ;
            {
                Console.WriteLine("\"Ошибка! Введите 1 или 2:\"");
            }
            if (choice == 1)
            {
                Main(args);
                return;
            }
        }
    }

    public class Player : Character
    {
        public int Potion { get; set; } = 3;
        public Player(string name)
            : base(name, 10, 5)
        { }
        public void UsePotion()
        {
            if (Potion > 0)
            {
                Potion--;
                Health += 10;
                Console.WriteLine($"{Name} использует спасительное зелье +10HP.\nОставшееся количество зелья {Potion}\nТекущее здоровье {Health}");
            }
            else { Console.WriteLine("Вы израсходовали все зелье"); }
        }
    }
    public class Monster : Character
    {
        public Monster()
            : base(name: "Злобный гоблин",
            health: 20,
            damage: new Random().Next(1, 7))
        { }
        public override void Attack(Character target)
        {
            Damage = new Random().Next(1, 7);
            base.Attack(target);
        }
    }
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public bool isAlive
        {
            get
            {
                return Health > 0;
            }
        }
        public Character(string name, int health, int damage)
        {
            Name = name; Health = health; Damage = damage;
        }
        public virtual void Attack(Character target)
        {
            if (!isAlive || !target.isAlive)
                return;
            target.Health -= Damage;
        }
    }
}


