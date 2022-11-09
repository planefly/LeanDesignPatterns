using System;

namespace IteratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(2);
            bookShelf.AppendBook(new Book("BOOK 1"));
            bookShelf.AppendBook(new Book("BOOK 2"));

            foreach (Book book in bookShelf)
            {
                Console.WriteLine(book.GetName());
            }

        }
    }
}
