namespace StatePattern
{
    public class NightState : State
    {
        private static readonly NightState _singleton = new NightState();

        private NightState() { }

        public static NightState GetInstance()
        {
            return _singleton;
        }

        public void DoClock(Context context, int hour)
        {
            if (hour >= 9 && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoUse(Context context)
        {
            context.CallSecurityCenter("紧急：晚上使用金库！");
        }

        public void DoAlarm(Context context)
        {
            context.CallSecurityCenter("按下警铃（晚上）");
        }
        public void DoPhone(Context context)
        {
            context.RecordingLog("晚上的通话录音");
        }

        public override string ToString()
        {
            return "[晚上]";
        }
    }
}
