namespace PatternsApp.Memento
{
    public class Editor
    {
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
            }
        }
        public Editor()
        {
            this.content = "";
        }
        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void RestoreState(EditorState state)
        {
            this.Content = state.Content;
        }
    }
}