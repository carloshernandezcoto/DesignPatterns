namespace PatternsApp.Memento
{
    public class Memento : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Memento pattern execution..." + Environment.NewLine);

            var editor = new Editor();
            var history = new History();
            editor.Content = "a";
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());
            editor.Content = "c";
            editor.RestoreState(history.Pop());

            Console.WriteLine("Current content: {0}", editor.Content);
            Console.ReadKey();
        }
    }
}