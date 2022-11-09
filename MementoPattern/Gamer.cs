using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class Gamer
    {
        private int _money;
        private List<string> _fruits = new List<string>();
        private readonly Random _random = new Random();
        private static readonly string[] _fruitKinds = { "苹果", "葡萄", "香蕉", "橘子" };

        public Gamer(int money)
        {
            _money = money;
        }

        public int GetMoney()
        {
            return _money;
        }

        public void Bet()
        {
            int dice = _random.Next(6) + 1;

            if (dice == 1)
            {
                _money += 100;
                Console.WriteLine("所持有的金钱增加了。");
            }
            else if (dice == 2)
            {
                _money /= 2;
                Console.WriteLine("所持有的金钱减半了。");
            }
            else if (dice == 6)
            {
                string f = GetFruit();
                Console.WriteLine($"获取水果({f})。");
                _fruits.Add(f);
            }
        }

        public Memento CreateMemento()
        {
            Memento m = new Memento(_money);
            foreach (string f in _fruits)
            {
                if (f.StartsWith("好吃的"))
                {
                    m.AddFruit(f);
                }
            }

            return m;
        }

        public void RestoreMemento(Memento memento)
        {
            _money = memento.GetMoney();
            _fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            string result = "";
            foreach (string f in _fruits)
            {
                result += f + ",";
            }

            if (result != "")
            {
                result = result.Substring(0, result.Length - 1);
            }

            return $"[money = {_money}, fruits = {result} ]";
        }

        private string GetFruit()
        {
            string prefix = "";
            if (_random.Next(2) == 0)
            {
                prefix = "好吃的";
            }

            return prefix + _fruitKinds[_random.Next(_fruitKinds.Length)];
        }
    }
}
