namespace PatternsApp.Memento
{
    public class History
    {
        private Stack<EditorState> states;

        public History()
        {
            this.states = new Stack<EditorState>();
        }

        public Stack<EditorState> States { get => states; set => states = value; }

        public void Push(EditorState state)
        {
            States.Push(state);
        }

        public EditorState Pop()
        {
            return States.Pop();
        }
    }
}