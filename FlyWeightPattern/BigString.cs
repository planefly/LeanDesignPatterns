namespace FlyWeightPattern
{
    public class BigString
    {
        private readonly BigChar[] _bigChars;

        public BigString(string str)
        {
            _bigChars = new BigChar[str.Length];

            for (int i = 0; i < _bigChars.Length; i++)
            {
                _bigChars[i] = BigCharFactory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            for (int i = 0; i < _bigChars.Length; i++)
            {
                _bigChars[i].Print();
            }
        }
    }
}
