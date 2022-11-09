using System.Collections.Generic;

namespace AbstractFactoryPattern.FactoryNs
{
    public abstract class Tray : Item
    {
        protected List<Item> Trays = new List<Item>();

        public Tray(string caption) :
            base(caption)
        {
        }

        public void Add(Item item)
        {
            Trays.Add(item);
        }
    }
}
