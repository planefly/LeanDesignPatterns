using System.Collections.Generic;

namespace PrototypePattern.Framework
{
    public class Manager
    {
        private readonly Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct product)
        {
            showcase.Add(name, product);
        }

        public IProduct Create(string product)
        {
            return (IProduct)showcase[product].Clone();
        }
    }
}
