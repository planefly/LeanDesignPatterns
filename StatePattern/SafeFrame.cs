using System;
using System.Threading;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class SafeFrame : Form, Context
    {
        public SafeFrame()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private State _state = DayState.GetInstance();

        private Thread _thread;
        private void SafeFrame_Load(object sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(SetClock));
            _thread.Start();
        }

        private void SafeFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            _thread.Abort();
        }

        private void ButtonUse_Click(object sender, EventArgs e)
        {
            _state.DoUse(this);
        }

        private void ButtonAlarm_Click(object sender, EventArgs e)
        {
            _state.DoAlarm(this);
        }

        private void ButtonPhone_Click(object sender, EventArgs e)
        {
            _state.DoPhone(this);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetClock()
        {
            while (true)
            {
                for (int hour = 0; hour < 24; hour++)
                {
                    SetClock(hour);
                    Thread.Sleep(1000);
                }
            }
        }

        public void SetClock(int hour)
        {
            string clockString = "现在的时间是";
            if (hour < 10)
            {
                clockString += "0" + hour + ":00";
            }
            else
            {
                clockString += hour + ":00";
            }

            Console.WriteLine(clockString);
            textClock.Text = clockString;
            _state.DoClock(this, hour);
        }

        public void ChangeState(State state)
        {
            Console.WriteLine($"从 {_state} 状态变为了 {state} 状态。");
            _state = state;
        }

        public void CallSecurityCenter(string msg)
        {
            textScreen.Text += $"call! {msg}\r\n";
        }

        public void RecordingLog(string msg)
        {
            textScreen.Text += $"record... {msg}\r\n";
        }
    }
}
