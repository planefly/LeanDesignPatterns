using System.Collections.Generic;

namespace CommandPattern
{
    public class MacroCommand : Command
    {
        private readonly Stack<Command> _commands = new Stack<Command>();

        public void Execute()
        {
            foreach (Command cmd in _commands)
            {
                cmd.Execute();
            }
        }

        public void Append(Command cmd)
        {
            if (cmd != null)
            {
                _commands.Push(cmd);
            }
        }

        public Command Undo()
        {
            if (_commands.Count != 0)
            {
                return _commands.Pop();
            }
            return null;
        }

        public void Clear()
        {
            _commands.Clear();
        }
    }
}
