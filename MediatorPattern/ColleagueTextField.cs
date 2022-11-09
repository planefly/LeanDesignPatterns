using System;
using System.Windows.Forms;

namespace MediatorPattern
{
    public partial class ColleagueTextField : TextBox, Colleague
    {
        public ColleagueTextField()
        {
            InitializeComponent();
        }

        private Mediator _mediator;

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void SetColleagueEnabled(bool enable)
        {
            Enabled = enable;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            _mediator.ColleagueChanged();

            base.OnTextChanged(e);
        }
    }
}
