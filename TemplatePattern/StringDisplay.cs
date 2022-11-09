using System;

namespace TemplateMethodPattern
{
    internal class StringDisplay : AbstractDisplay
    {
        private readonly string _str;
        private readonly int _width;

        public StringDisplay(string str)
        {
            _str = str;
            _width = _str.Length;
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}
