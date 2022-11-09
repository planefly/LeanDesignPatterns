namespace InterpreterPattern
{
    public class RepeatCommandNode : Node
    {
        private int _number;
        private Node _commandListNode;

        public override void Parse(Context context)
        {
            context.SkipToken("repeat");
            _number = context.CurrentNumber();
            context.NextToken();
            _commandListNode = new NodeList();
            _commandListNode.Parse(context);
        }

        public override string ToString()
        {
            return $"[repeat {_number} {_commandListNode}]";
        }
    }
}
