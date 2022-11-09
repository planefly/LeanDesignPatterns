namespace FactoryMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IDCardFactory factory = new IDCardFactory();
            Framework.Product card1 = factory.Create("小明");
            Framework.Product card2 = factory.Create("小红");
            Framework.Product card3 = factory.Create("小刚");
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
