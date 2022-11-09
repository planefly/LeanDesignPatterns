using System;

namespace StrategyPattern
{
    public class ProbStrategy : Strategy
    {
        private readonly Random _random;

        private int _prevHandValue = 0;

        private int _currentHandValue = 0;

        private readonly int[][] _history =
        {
          new int[]  { 1,1,1},
          new int[]  { 1,1,1},
          new int[]  { 1,1,1},
        };

        public ProbStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            int bet = _random.Next(GetSum(_currentHandValue));
            int handvalue;
            if (bet < _history[_currentHandValue][0])
            {
                handvalue = 0;
            }
            else if (bet < _history[_currentHandValue][0] + _history[_currentHandValue][1])
            {
                handvalue = 1;
            }
            else
            {
                handvalue = 2;
            }

            _prevHandValue = _currentHandValue;
            _currentHandValue = handvalue;

            return Hand.GetHand(handvalue);
        }

        public void Study(bool win)
        {
            if (win)
            {
                _history[_prevHandValue][_currentHandValue]++;
            }
            else
            {
                _history[_prevHandValue][(_currentHandValue + 1) % 3]++;
                _history[_prevHandValue][(_currentHandValue + 2) % 3]++;
            }
        }

        private int GetSum(int hv)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += _history[hv][i];
            }

            return sum;
        }
    }
}
