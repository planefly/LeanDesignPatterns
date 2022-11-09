using System;

namespace AdapterPattern
{
    internal class Banner
    {
        private readonly string _str;

        public Banner(string str)
        {
            _str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({_str})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{_str}*");
        }
    }
}
