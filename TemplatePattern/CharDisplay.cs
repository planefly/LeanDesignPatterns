using System;

namespace TemplateMethodPattern
{
    internal class CharDisplay : AbstractDisplay
    {
        private readonly char _ch;

        public CharDisplay(char ch)
        {
            _ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(_ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
