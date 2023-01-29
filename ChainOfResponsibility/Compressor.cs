namespace PatternsApp.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next) { }
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Compressor called..");
            return true;
        }
    }
}