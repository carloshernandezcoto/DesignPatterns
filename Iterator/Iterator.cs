namespace PatternsApp.Iterator
{
    public class Iterator : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Iterator pattern execution..." + Environment.NewLine);
            var history = new BrowseHistory();
            var iterator = history.CreateIterator();
            history.Push("www.aqui.com");
            history.Push("www.alla.com");
            history.Push("www.todos.com");

            while (!iterator.Done())
            {
                var current = iterator.Current();
                Console.WriteLine(current);
                iterator.Next();
            }
            Console.ReadKey();
        }
    }
}