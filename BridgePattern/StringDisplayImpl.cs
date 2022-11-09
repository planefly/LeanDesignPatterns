using System;

namespace BridgePattern
{
    public class StringDisplayImpl : DisplayImpl
    {
        private readonly string _str;
        private readonly int _width;

        public StringDisplayImpl(string str)
        {
            _str = str;
            _width = str.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void RawClose()
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
