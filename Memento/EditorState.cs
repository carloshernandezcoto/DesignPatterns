namespace PatternsApp.Memento
{
    public class EditorState
    {
        private readonly string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        public string Content => content;

    }
}