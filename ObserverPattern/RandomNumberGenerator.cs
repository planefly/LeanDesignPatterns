using System;

namespace ObserverPattern
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private readonly Random _random = new Random();
        private int _number;

        public override int GetNumber()
        {
            return _number;
        }

        public override void Execute()
        {
            for (int i = 0; i < 20; i++)
            {
                _number = _random.Next(50);
                NotifyObserver();
            }
        }
    }
}
