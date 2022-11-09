namespace AbstractFactoryPattern.FactoryNs
{
    public abstract class Item
    {
        protected string Capation;
        public Item(string caption)
        {
            Capation = caption;
        }
        public abstract string MakeHTML();
    }
}
