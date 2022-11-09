using System;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class LoginFrame : Form, Mediator
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LoginFrame_Load(object sender, EventArgs e)
        {
            CreateColleagues();
        }

        public void CreateColleagues()
        {
            checkGuest.SetMediator(this);
            checkLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOK.SetMediator(this);
            buttonCancel.SetMediator(this);
        }

        public void ColleagueChanged()
        {
            if (checkGuest.Checked)
            {
                textUser.Enabled = false;
                textPass.Enabled = false;
            }
            else
            {
                textUser.Enabled = true;
                UserPassChanged();
            }
        }

        private void UserPassChanged()
        {
            if (textUser.Text.Length > 0)
            {
                textPass.Enabled = true;
                buttonOK.Enabled = textPass.Text.Length > 0;
            }
            else
            {
                textPass.Enabled = false;
                buttonOK.Enabled = false;
            }
        }
    }
}
