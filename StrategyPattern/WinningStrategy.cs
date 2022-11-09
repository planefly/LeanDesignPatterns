using System;

namespace StrategyPattern
{
    public class WinningStrategy : Strategy
    {
        private readonly Random _random;

        private bool _won = false;

        private Hand prevHand;

        public WinningStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            if (!_won)
            {
                prevHand = Hand.GetHand(_random.Next(2));
            }

            return prevHand;
        }

        public void Study(bool win)
        {
            _won = win;
        }
    }
}
