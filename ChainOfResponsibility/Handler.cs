namespace PatternsApp.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;

        protected Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (!DoHandle(request))
                return;
            if (next != null)
                next.Handle(request);
        }
        public abstract bool DoHandle(HttpRequest request);
    }
}