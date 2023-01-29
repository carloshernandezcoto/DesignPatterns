namespace PatternsApp.Mediator
{
    public abstract class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler observer)
        {
            eventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers()
        {
            eventHandlers.ForEach(o => o.Handle(this));
        }
    }
}