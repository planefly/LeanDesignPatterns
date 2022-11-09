namespace StrategyPattern
{
    public class Hand
    {
        public static int HANDVALUE_GUU = 0;
        public static int HANDVALUE_CHO = 1;
        public static int HANDVALUE_PAA = 2;

        public static Hand[] Hands = {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA)
        };

        private static readonly string[] _names = { "剪刀", "石头", "布" };

        private readonly int _handValue;

        private Hand(int handValue)
        {
            _handValue = handValue;
        }

        public static Hand GetHand(int handValue)
        {
            return Hands[handValue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((_handValue + 1) % 3 == h._handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return _names[_handValue];
        }
    }
}
