using System.Collections.Generic;

namespace FlyWeightPattern
{
    public static class BigCharFactory
    {
        private static readonly Dictionary<char, BigChar> _pool = new Dictionary<char, BigChar>();

        public static BigChar GetBigChar(char charName)
        {
            if (_pool.ContainsKey(charName))
            {
                return _pool[charName];
            }

            return new BigChar(charName);
        }
    }
}
