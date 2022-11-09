namespace InterpreterPattern
{
    public class CommandNode : Node
    {
        private Node _node;

        public override void Parse(Context context)
        {
            if (context.CurrentToken() == "repeat")
            {
                _node = new RepeatCommandNode();
                _node.Parse(context);
            }
            else
            {
                _node = new PrimitiveCommandNode();
                _node.Parse(context);
            }
        }

        public override string ToString()
        {
            return _node.ToString();
        }
    }
}
