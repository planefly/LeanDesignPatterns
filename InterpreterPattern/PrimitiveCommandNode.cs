using System;

namespace InterpreterPattern
{
    public class PrimitiveCommandNode : Node
    {
        private string _name;

        public override void Parse(Context context)
        {
            _name = context.CurrentToken();
            context.SkipToken(_name);
            if (_name != "go" && _name != "right" && _name != "left")
            {
                throw new Exception($"{_name} is underfined");
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
