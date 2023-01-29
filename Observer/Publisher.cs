namespace PatternsApp.Observer
{
    public abstract class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void UnSubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void Notifysubscribers()
        {
            subscribers.ForEach(s => s.Update());
        }
    }
}