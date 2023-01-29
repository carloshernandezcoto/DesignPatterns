namespace PatternsApp.Command.fx
{
    public interface ICommand
    {
        public string Name { get; }
        public void Execute();
    }
}