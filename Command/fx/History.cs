namespace PatternsApp.Command.fx
{
    public class History
    {
        private Stack<IUndoableCommand> commands = new Stack<IUndoableCommand>();

        public int Size { get => commands.Count; }

        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return commands.Count > 0 ? commands.Pop() : null;
        }
    }
}