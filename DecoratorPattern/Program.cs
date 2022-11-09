namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringDisplay b1 = new StringDisplay("Hello, World.");
            SideBorder b2 = new SideBorder(b1, '#');
            FullBorder b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();

            SideBorder b4 = new SideBorder(
                new FullBorder(
                    new FullBorder(
                        new FullBorder(
                            new SideBorder(
                                new FullBorder(new StringDisplay("Hello, Decorator Pattern.")), '*')
                            ))), '/');
            b4.Show();

        }
    }
}
