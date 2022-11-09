namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomNumberGenerator gen = new RandomNumberGenerator();
            DigitObserver o1 = new DigitObserver();
            GraphObserver o2 = new GraphObserver();
            gen.AddObserver(o1);
            gen.AddObserver(o2);
            gen.Execute();
        }
    }
}
