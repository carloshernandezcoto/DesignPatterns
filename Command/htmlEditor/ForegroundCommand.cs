using PatternsApp.Command.fx;

namespace PatternsApp.Command.htmlEditor
{
    public class ForegroundCommand : IUndoableCommand
    {
        private string name = "Foreground";
        private ConsoleColor newColor;
        private ConsoleColor prevColor;
        private HtmlDocument document;
        private History history;
        public ConsoleColor NewColor { get => newColor; set => newColor = value; }
        public string Name { get => name; }

        public ForegroundCommand(HtmlDocument document, History history, ConsoleColor newColor)
        {
            this.document = document;
            this.history = history;
            this.NewColor = newColor;
        }
        public void Execute()
        {
            PrintAppMsg.Print("---> Foreground command called... Color = " + newColor);
            prevColor = document.ForeGroundColor;
            document.SetForegroundColor(newColor);
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetForegroundColor(prevColor);
        }
    }
}