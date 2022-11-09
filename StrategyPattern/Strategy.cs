namespace StrategyPattern
{
    public interface Strategy
    {
        Hand NextHand();
        void Study(bool win);
    }
}
