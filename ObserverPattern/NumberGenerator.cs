using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class NumberGenerator
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DeleteOberver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (Observer o in _observers)
            {
                o.Update(this);
            }
        }

        public abstract int GetNumber();

        public abstract void Execute();
    }
}
