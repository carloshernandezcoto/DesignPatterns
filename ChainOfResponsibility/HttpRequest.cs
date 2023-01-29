namespace PatternsApp.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string username;
        private string password;

        public HttpRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; }
        public string Password { get => password; }
    }
}