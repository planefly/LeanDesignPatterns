using FactoryMethodPattern.Framework;
using System;

namespace FactoryMethodPattern
{
    public class IDCard : Product
    {
        private readonly string _owner;

        public IDCard(string owner)
        {
            Console.WriteLine($" 制作 {owner} 的 ID 卡。");
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($" 使用 {_owner} 的 ID 卡。");
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}
