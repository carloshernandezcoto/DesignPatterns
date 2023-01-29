namespace PatternsApp.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            System.Console.WriteLine("Authenticator called...");
            var isValid = request.Username == "Admin" && request.Password == "1234";
            return isValid;
        }
    }
}