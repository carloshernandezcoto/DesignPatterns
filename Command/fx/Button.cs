namespace PatternsApp.Command.fx
{
    public class Button
    {
        private string label = "";
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public string Label { get => label; set => label = value; }

        public void Click()
        {
            command.Execute();
        }
    }
}