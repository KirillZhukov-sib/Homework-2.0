using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat("Мурка", "черный", 1);
            //Cat cat2 = new Cat("Мурка", "черный", 1);

            Book book1 = new Book("War and peace", "L. Tolstoy", "1869", "1225 pages");

            book1.year = "2025";
            book1._author = "Pushkin";
            //book1._title = "Capitans dauther";
            book1.pages = "231";

            book1.GetInfo();

            Console.ReadKey();
        }
    }

    public class Book
    {
        public string _title;
        public string _author;

        public string year { get; set; }
        public string pages { get; set; }

        public Book(string _title, string _author, string year, string pages)
        {
            this._title = _title;
            this._author = _author;
            this.year = year;
            this.pages = pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{_title}, {_author}, {year}, {pages}");
        }
    }
}
