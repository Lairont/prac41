using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public delegate int BookComparer(Book book1, Book book2);

    internal class BookSort
    {
        private List<Book> books = new List<Book>();
        public List<Book> Books => books;
        public void SortBooks(BookComparer comparer)
        {
            books.Sort(new Comparison<Book>(comparer)); 
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
