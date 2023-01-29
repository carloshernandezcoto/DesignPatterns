namespace PatternsApp.Observer
{
    public class Spreadsheet : ISubscriber
    {
        private DataSource ds;

        public Spreadsheet(DataSource ds)
        {
            this.ds = ds;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified. DS value: {0}", ds.Value);
        }
    }
}