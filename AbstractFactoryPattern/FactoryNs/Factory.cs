namespace AbstractFactoryPattern.FactoryNs
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            return (Factory)typeof(Factory).Assembly.CreateInstance(className);
        }

        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}
