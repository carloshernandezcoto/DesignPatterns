namespace PatternsApp.Command.fx
{
    public class CompositeCommand : ICommand
    {
        private string name = "Composite";
        public string Name { get => name; }
        private List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }
        public void Execute()
        {
            commands.ForEach(c => c.Execute());
        }
    }
}