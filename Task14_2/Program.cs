using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> shop = new Dictionary<string, int>();

            
            shop.Add("A001", 10);  
            shop.Add("B205", 25);  
            shop.Add("C307", 15);  

            bool hasB205 = shop.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasB205}");

            shop["A001"] = 8;

            if (shop.TryGetValue("C307", out int headphonesCount))
            {
                Console.WriteLine($"Количество наушников: {headphonesCount}");
            }

            shop["B205"] += 5;

            shop.Remove("C307");

            Console.WriteLine("Текущие товары:");
            foreach (var item in shop)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            bool isEmpty = shop.Count == 0;
            Console.WriteLine($"Список пуст? {isEmpty}");

            shop.Clear();

            Console.WriteLine($"Количество товаров после очистки: {shop.Count}");

        }
    }
}
