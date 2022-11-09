namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NoSupport alice = new NoSupport("Alice");
            LimitSupport bob = new LimitSupport("Bob", 100);
            SpecialSupport charlie = new SpecialSupport("Charlie", 429);
            LimitSupport diana = new LimitSupport("Diana", 200);
            OddSupport elmo = new OddSupport("Elmo");
            LimitSupport fred = new LimitSupport("Fred", 300);

            alice.SetNext(bob).
                SetNext(charlie).
                SetNext(diana).
                SetNext(elmo).
                SetNext(fred);

            for (int i = 0; i < 500; i += 30)
            {
                alice.SupportTrouble(new Trouble(i));
            }
        }
    }
}
