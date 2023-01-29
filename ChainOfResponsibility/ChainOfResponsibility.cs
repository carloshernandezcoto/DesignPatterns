namespace PatternsApp.ChainOfResponsibility
{
    public class ChainOfResponsibility : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Chain of Responsibility pattern execution..." + Environment.NewLine);
            var compressorHandler = new Compressor(null);
            var loggerHandler = new Logger(compressorHandler);
            var authenticationHandler = new Authenticator(loggerHandler);
            var ws = new WebServer(authenticationHandler);

            var request = new HttpRequest("Admin", "12s34");
            ws = new WebServer(authenticationHandler);
            ws.Handle(request);
            Console.ReadKey();
        }
    }
}