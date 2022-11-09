using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class ColleagueButton : Button, Colleague
    {
        public ColleagueButton()
        {
            InitializeComponent();
        }

        public void SetMediator(Mediator mediator)
        {
        }

        public void SetColleagueEnabled(bool enable)
        {
            Enabled = enable;
        }
    }
}
