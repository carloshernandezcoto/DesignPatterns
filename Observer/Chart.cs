namespace PatternsApp.Observer
{
    public class Chart : ISubscriber
    {
        private DataSource ds;
        public Chart(DataSource ds)
        {
            this.ds = ds;
        }
        public void Update()
        {
            Console.WriteLine("Chart got notified. DS value: {0}", ds.Value);
        }
    }
}