using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    //  <command list> ::= <command>* end
    public class NodeList : Node
    {
        private readonly List<Node> _nodes = new List<Node>();

        public override void Parse(Context context)
        {
            while (true)
            {
                if (context.CurrentToken() == null)
                {
                    throw new Exception("Missing 'end'");
                }
                else if (context.CurrentToken() == "end")
                {
                    context.SkipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.Parse(context);
                    _nodes.Add(commandNode);
                }
            }
        }

        public override string ToString()
        {
            string result = "[";

            foreach (var node in _nodes)
                result += node.ToString() + " ";

            result = result.TrimEnd();

            result += "]";

            return result;
        }
    }
}
