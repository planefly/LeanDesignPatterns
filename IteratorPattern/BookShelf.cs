using System.Collections;

namespace IteratorPattern
{
    internal class BookShelf : IEnumerable
    {
        private readonly Book[] _books;

        private int _last = 0;

        public BookShelf(int maxSize)
        {
            _books = new Book[maxSize];
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books[_last] = book;
            _last++;
        }

        public IEnumerator GetEnumerator()
        {
            //foreach (Book book in books)
            //    yield return book;

            return new BookShelfEnumerator(_books);
        }
    }
}
