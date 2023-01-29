using PatternsApp.Command.fx;

namespace PatternsApp.Command.htmlEditor
{
    public class BackgroundCommand : IUndoableCommand
    {
        private string name;
        private ConsoleColor newColor;
        private ConsoleColor prevColor;
        private HtmlDocument document;
        private History history;
        public ConsoleColor NewColor { get => newColor; set => newColor = value; }
        public string Name { get => name; }

        public BackgroundCommand(HtmlDocument document, History history, ConsoleColor newColor)
        {
            this.document = document;
            this.history = history;
            this.NewColor = newColor;
            this.name = "Background";
        }
        public void Execute()
        {
            PrintAppMsg.Print("---> Background command called... Color = " + newColor);
            prevColor = document.BackgroundColor;
            document.SetBackgroundColor(newColor);
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetBackgroundColor(prevColor);
        }
    }
}


