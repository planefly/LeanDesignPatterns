namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CharDisplay d1 = new CharDisplay('H');

            StringDisplay d2 = new StringDisplay("Hello, world.");

            d1.Display();

            d2.Display();
        }
    }
}
