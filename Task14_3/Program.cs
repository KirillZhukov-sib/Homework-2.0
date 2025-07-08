using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Добавляем подписчиков:");
            bool addedAlice = subscribers.Add("alice@example.com");
            bool addedBob = subscribers.Add("bob@example.com");
            bool addedCharlie = subscribers.Add("charlie@example.com");

            bool addedAliceDuplicate = subscribers.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {addedAliceDuplicate}");

            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            var newSubscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
            "bob@example.com",
            "dave@example.com",
            "eve@example.com"
            };

            subscribers.UnionWith(newSubscribers);
            Console.WriteLine("\nПодписчики после объединения:");
            foreach (var email in subscribers)
            {
                Console.WriteLine($"- {email}");
            }

            var common = new HashSet<string>(subscribers);
            common.IntersectWith(newSubscribers);
            Console.WriteLine("\nОбщие подписчики:");
            foreach (var email in common)
            {
                Console.WriteLine($"- {email}");
            }

            bool removedCharlie = subscribers.Remove("charlie@example.com");
            Console.WriteLine($"\nУдалили charlie@example.com? {removedCharlie}");
            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            var testGroup = new HashSet<string> { "bob@example.com", "eve@example.com" };
            bool isSubset = testGroup.IsSubsetOf(subscribers);
            Console.WriteLine($"testGroup является подмножеством? {isSubset}");

            subscribers.Clear();
            Console.WriteLine($"\nПодписчиков после очистки: {subscribers.Count}");

        }
    }
}
