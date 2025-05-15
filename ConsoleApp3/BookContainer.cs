using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    delegate int BookComparison(Book book1, Book book2);
    class BookContainer
    {
        private Book[] books;
        public BookContainer(Book[] books)
        {
            this.Books = books;
        }

        internal Book[] Books { get => books; set => books = value; }

        public void Sort(BookComparison comp)
        {
            Array.Sort(Books, new Comparison<Book>(comp));
        }
        public void Info()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
