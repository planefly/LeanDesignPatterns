namespace StatePattern
{
    public class DayState : State
    {
        private static readonly DayState _singleton = new DayState();

        private DayState() { }

        public static DayState GetInstance()
        {
            return _singleton;
        }

        public void DoClock(Context context, int hour)
        {
            if (hour < 9 || hour >= 17)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoUse(Context context)
        {
            context.RecordingLog("使用金库（白天）");
        }

        public void DoAlarm(Context context)
        {
            context.RecordingLog("按下警铃（白天）");
        }

        public void DoPhone(Context context)
        {
            context.RecordingLog("正常通话（白天）");
        }

        public override string ToString()
        {
            return "[白天]";
        }
    }
}
