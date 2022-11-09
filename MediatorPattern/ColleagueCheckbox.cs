using System;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class ColleagueCheckbox : RadioButton, Colleague
    {
        private Mediator _mediator;

        public ColleagueCheckbox()
        {
            InitializeComponent();
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void SetColleagueEnabled(bool enable)
        {
            Enabled = enable;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            _mediator.ColleagueChanged();

            base.OnCheckedChanged(e);
        }
    }
}
