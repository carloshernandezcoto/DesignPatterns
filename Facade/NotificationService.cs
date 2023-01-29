namespace PatternsApp.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connection("123.456.678.987");
            var authToken = server.Authenticate("AnAppId", "APrivateKey");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}