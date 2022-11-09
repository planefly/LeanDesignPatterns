using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        private readonly MacroCommand _history = new MacroCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.SetHistory(_history);
        }

        private void DrawCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawCommand cmd = new DrawCommand(canvas, e.Location);
                cmd.Execute();
                _history.Append(cmd);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            canvas.Color = SystemColors.Control;
            _history.Execute();
            canvas.Color = Color.Red;
        }

        private void ButtonClearHistory_Click(object sender, EventArgs e)
        {
            ButtonClear_Click(sender, e);
            _history.Clear();
        }

        private void ButtonRedraw_Click(object sender, EventArgs e)
        {
            canvas.DrawAll();
        }

        private void ButtonUndo_Click(object sender, EventArgs e)
        {
            Command cmd = _history.Undo();
            if (cmd == null)
            {
                return;
            }

            canvas.Color = SystemColors.Control;
            cmd.Execute();
            canvas.Color = Color.Red;
        }
    }
}
