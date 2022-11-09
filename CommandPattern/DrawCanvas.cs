using System.Drawing;
using System.Windows.Forms;

namespace CommandPattern
{
    public class DrawCanvas : Panel, Drawable
    {
        public Color Color { get; set; } = Color.Red;
        private readonly int _radius = 6;
        private MacroCommand _history;

        public void SetHistory(MacroCommand history)
        {
            _history = history;
        }

        public void DrawAll()
        {
            _history.Execute();
        }

        public void Draw(int x, int y)
        {
            Graphics g = base.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color);
            Rectangle rect = new Rectangle(x - _radius / 2, y - _radius / 2, _radius, _radius);
            g.FillPie(brush, rect, 0, 360);
        }
    }
}
