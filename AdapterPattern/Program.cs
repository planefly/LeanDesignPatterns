//using AdapterPattern.InterfaceMethod;
using AdapterPattern.DeputeMethod;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintBanner p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
