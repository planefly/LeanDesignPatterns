namespace StatePattern
{
    public interface Context
    {
        void SetClock(int hour);
        void ChangeState(State state);
        void CallSecurityCenter(string msg);
        void RecordingLog(string msg);
    }
}
