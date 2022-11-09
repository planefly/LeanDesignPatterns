using System;
using System.IO;

namespace FlyWeightPattern
{
    public class BigChar
    {
        private readonly string _fontData;

        public BigChar(char charName)
        {
            _fontData = File.ReadAllText($"big{charName}.txt");
        }

        public void Print()
        {
            Console.WriteLine("****");
            Console.WriteLine($"*{_fontData}*");
            Console.WriteLine("****");
            Console.WriteLine();
        }
    }
}
