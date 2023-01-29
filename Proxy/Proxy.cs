namespace PatternsApp.Proxy
{
    public class Proxy : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Proxy pattern execution..." + Environment.NewLine);

            var library = new Library();
            string[] fileNames = { "a", "b", "c" };
            foreach (var fileName in fileNames)
            {
                library.Add(new LoggingEbookProxy(fileName));
            }

            library.OpenEbook("a");
            library.OpenEbook("c");
            Console.ReadKey();
        }
    }
}