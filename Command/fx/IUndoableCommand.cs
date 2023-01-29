namespace PatternsApp.Command.fx
{
    public interface IUndoableCommand : ICommand
    {
        public void Unexecute();
    }
}