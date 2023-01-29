namespace PatternsApp.Command.fx
{
    public class UndoCommand : ICommand
    {
        private string name;
        private History history;
        public string Name { get => name; set => name = value; }
        public UndoCommand(History history)
        {
            this.name = "Undo";
            this.history = history;
        }
        public void Execute()
        {
            IUndoableCommand? currentCommand = history.Pop();
            if (currentCommand != null)
            {
                currentCommand.Unexecute();
                PrintAppMsg.Print("---> Undo command called..." + " Undoing " + currentCommand.Name);
            }
            else
                PrintAppMsg.Print("---> Undo command called..." + " Nothing to undo ");
        }
    }
}