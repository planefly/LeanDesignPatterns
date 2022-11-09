using System;

namespace SingletonPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Singleton o1 = Singleton.GetInstance();
            Singleton o2 = Singleton.GetInstance();

            Console.WriteLine($"o1 {(o1 == o2 ? "==" : "!=")} o2");
        }
    }
}
