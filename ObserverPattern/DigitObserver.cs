using System;
using System.Threading;

namespace ObserverPattern
{
    public class DigitObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine($"DigitObserver: {generator.GetNumber()}");
            Thread.Sleep(100);
        }
    }
}
