using PrototypePattern.Framework;
using System;

namespace PrototypePattern
{
    public class UnderlinePen : IProduct
    {
        private readonly char _ulChar;

        public UnderlinePen(char c)
        {
            _ulChar = c;
        }

        public void Use(string s)
        {
            int length = s.Length;
            Console.WriteLine($"\"{s}\"");

            for (int i = 0; i < length; i++)
            {
                Console.Write(_ulChar);
            }

            Console.WriteLine("");
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
