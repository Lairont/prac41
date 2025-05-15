using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Book
    {
        private string title, author, publisher;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public static Book Enter()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Издательство: ");
            string publisher = Console.ReadLine();
            return new Book(title, author, publisher);
        }

        public override string ToString()
        {
            return $"Название: {Title}\nАвтор: {Author}\nИздательсво: {Publisher}\n";
        }

    }
}
