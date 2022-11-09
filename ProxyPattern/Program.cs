using System;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrinterProxy p = new PrinterProxy("Alice");
            Console.WriteLine($"现在的名字是{p.GetPrinterName()}。");
            p.SetPrinterName("Bob");
            Console.WriteLine($"现在的名字是{p.GetPrinterName()}。");
            p.Print("Hello, world.");
        }
    }
}
