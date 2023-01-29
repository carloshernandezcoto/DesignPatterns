namespace PatternsApp.Iterator
{
    public class BrowseHistory
    {
        //Stack implementation
        // private Stack<string> urls = new Stack<string>();

        // public Stack<string> Urls { get => urls; }

        // public IIterator<string> CreateIterator()
        // {
        //     return new StackIterator<string>(urls);
        // }

        //List implementation
        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var lastUrl = urls[urls.Count - 1];
            urls.RemoveAt(urls.Count - 1);
            return lastUrl;
        }
        public IIterator<string> CreateIterator()
        {
            return new ListIterator<string>(urls);
        }
    }
}