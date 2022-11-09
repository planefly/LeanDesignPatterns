using System.Collections;

namespace IteratorPattern
{
    internal class BookShelfEnumerator : IEnumerator
    {
        private readonly Book[] _books;
        private int position = -1;

        public BookShelfEnumerator(Book[] books)
        {
            _books = books;
        }

        public object Current => _books[position];

        public bool MoveNext()
        {
            position++;
            return position < _books.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
