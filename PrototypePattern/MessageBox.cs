using PrototypePattern.Framework;
using System;

namespace PrototypePattern
{
    public class MessageBox : IProduct
    {
        private readonly char _decoChar;

        public MessageBox(char c)
        {
            _decoChar = c;
        }

        public void Use(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(_decoChar);
            }

            Console.WriteLine("");

            Console.WriteLine($"{_decoChar} {s} {_decoChar}");

            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(_decoChar);
            }

            Console.WriteLine("");
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
