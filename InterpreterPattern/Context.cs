using System;

namespace InterpreterPattern
{
    public class Context
    {
        private readonly string[] _tokenlizers;

        private int _currentIndex;

        public Context(string text)
        {
            _tokenlizers = text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            _currentIndex = -1;
            NextToken();
        }

        public string NextToken()
        {
            _currentIndex++;

            if (_currentIndex >= _tokenlizers.Length - 1)
                return null;

            return _tokenlizers[_currentIndex];
        }

        public string CurrentToken()
        {
            return _tokenlizers[_currentIndex];
        }

        public void SkipToken(string token)
        {
            if (token != _tokenlizers[_currentIndex])
            {
                throw new Exception($"Warning: {token} is expected, but {_tokenlizers[_currentIndex]} is found.");
            }
            NextToken();
        }

        public int CurrentNumber()
        {
            return int.Parse(_tokenlizers[_currentIndex]);
        }
    }
}
