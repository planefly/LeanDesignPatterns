using System.Collections.Generic;

namespace MementoPattern
{
    public class Memento
    {
        private readonly int _money;

        private readonly List<string> _fruits;

        public Memento(int money)
        {
            _money = money;
            _fruits = new List<string>();
        }

        public int GetMoney()
        {
            return _money;
        }

        public void AddFruit(string fruit)
        {
            _fruits.Add(fruit);
        }

        public List<string> GetFruits()
        {
            List<string> result = new List<string>();

            foreach (string f in _fruits)
            {
                result.Add(f);
            }

            return result;
        }
    }
}
