namespace PatternsApp.Observer
{
    public class DataSource : Publisher
    {
        private int value;

        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                Notifysubscribers();
            }
        }
    }
}