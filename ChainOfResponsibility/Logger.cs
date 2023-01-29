namespace PatternsApp.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Logger called...");
            return true;
        }

    }
}