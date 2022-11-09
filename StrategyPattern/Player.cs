namespace StrategyPattern
{
    public class Player
    {
        private readonly string _name;
        private readonly Strategy _strategy;
        private int _winCount;
        private int _loseCount;
        private int _gameCount;
        public Player(string name, Strategy strategy)
        {
            _name = name;
            _strategy = strategy;
        }

        public Hand NextHand()
        {
            return _strategy.NextHand();
        }

        public void Win()
        {
            _strategy.Study(true);
            _winCount++;
            _gameCount++;
        }

        public void Lose()
        {
            _strategy.Study(false);
            _loseCount++;
            _gameCount++;
        }

        public void Even()
        {
            _gameCount++;
        }

        public override string ToString()
        {
            return $"[{_name}:{_gameCount} games, {_winCount} win, {_loseCount} lose]";
        }
    }
}
