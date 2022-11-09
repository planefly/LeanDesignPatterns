using System.Drawing;

namespace CommandPattern
{
    public class DrawCommand : Command
    {
        protected Drawable _drawable;

        private Point _position;

        public DrawCommand(Drawable drawable, Point position)
        {
            _drawable = drawable;
            _position = position;
        }

        public void Execute()
        {
            _drawable.Draw(_position.X, _position.Y);
        }
    }
}
