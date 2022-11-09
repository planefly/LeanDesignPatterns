using System;
using System.Threading;

namespace ObserverPattern
{
    public class GraphObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.Write("GraphObserver:");
            int count = generator.GetNumber();
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Thread.Sleep(100);
        }
    }
}
