namespace PatternsApp.Proxy
{
    public class Library
    {
        Dictionary<string, IEBook> ebooks = new Dictionary<string, IEBook>();

        public void Add(IEBook ebook)
        {
            ebooks.Add(ebook.FileName, ebook);
        }
        public void OpenEbook(string fileName)
        {
            ebooks[fileName].Show();
        }
    }
}