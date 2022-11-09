namespace MediatorPattern
{
    public interface Colleague
    {
        void SetMediator(Mediator mediator);
        void SetColleagueEnabled(bool enable);
    }
}
