using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //первый массив
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int> ("F-1234", "Война и мир", 1878, "Толстой"),
                new Book<string, int> ("F-1235", "Преступление и наказание", 1713, "Достоевский"),
            };

            var book1 = FindBook(books1, "F-1234");
            Console.WriteLine(book1?.ToString()??"Книга не найдена");

            //второй массив
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string> (42, "Гарри Поттер", "2003", "Роулинг"),
                new Book<int, string> (43, "Властелин Колец", "1988", "Толкин")
            };

            var book2 = FindBook(books2, 42);
            Console.WriteLine(book2?.ToString()??"Книга не найдена");
        }

        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }

        public class Book<T, U>
        {
            public T Code { get; set; }
            public string Title { get; set; }
            public U PublicationYear { get; set; }
            public string Author { get; set; }

            public Book(T code, string title, U publicationyear, string author)
            {
                Code = code; Title = title; PublicationYear = publicationyear; Author = author;
            }

            public override string ToString()
            {
                return $"ID: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
            }

        }
    }
}

