using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookSort booksort = new BookSort();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Сортировать по названию");
                Console.WriteLine("3. Сортировать по автору");
                Console.WriteLine("4. Сортировать по издательству");
                Console.WriteLine("5. Вывести книги");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        booksort.AddBook(Book.Enter());
                        break;
                    case 2:
                        booksort.SortBooks(SortTitle);
                        Console.WriteLine("Отсортировано по названию");
                        foreach (Book book in booksort.Books)
                            Console.WriteLine(book);
                        break;
                    case 3:
                        booksort.SortBooks(SortAuthor);
                        Console.WriteLine("Отсортировано по автору");
                        foreach (Book book in booksort.Books)
                            Console.WriteLine(book);
                        break;
                    case 4:
                        booksort.SortBooks(SortPublisher);
                        Console.WriteLine("Отсортировано по издательству");
                        foreach (Book book in booksort.Books)
                            Console.WriteLine(book);
                        break;
                    case 5:
                        foreach (Book book in booksort.Books)
                            Console.WriteLine(book);
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

                Console.ReadKey();
            }
        }

        public static int SortTitle(Book book1, Book book2)
        {
            return Comparer<string>.Default.Compare(book1?.Title, book2?.Title);
        }

        public static int SortAuthor(Book book1, Book book2)
        {
            return Comparer<string>.Default.Compare(book1?.Author, book2?.Author);
        }

        public static int SortPublisher(Book book1, Book book2)
        {
            return Comparer<string>.Default.Compare(book1?.Publisher, book2?.Publisher);
        }
    }
}