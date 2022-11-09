namespace IteratorPattern
{
    internal class Book
    {
        private readonly string _name;

        public Book(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
