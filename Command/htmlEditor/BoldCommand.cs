using PatternsApp.Command.fx;

namespace PatternsApp.Command.htmlEditor
{
    public class BoldCommand : IUndoableCommand
    {
        private string name;
        private string? prevContent;
        private HtmlDocument document;
        private History history;

        public string Name { get => name; }
        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
            this.name = "Bold";
        }
        public void Execute()
        {
            PrintAppMsg.Print("---> Bold command called...");
            prevContent = document.Content;
            document.makeBold();
            history.Push(this);
        }
        public void Unexecute()
        {
            document.Content = prevContent;
        }
    }
}