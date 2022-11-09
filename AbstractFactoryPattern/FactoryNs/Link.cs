namespace AbstractFactoryPattern.FactoryNs
{
    public abstract class Link : Item
    {
        protected string Url;
        public Link(string caption, string url) :
            base(caption)
        {
            Url = url;
        }
    }
}
