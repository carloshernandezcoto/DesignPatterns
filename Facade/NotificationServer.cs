namespace PatternsApp.Facade
{
    public class NotificationServer
    {
        //connect -> connection
        //authenticate(appId, key) -> authToken
        //send(authToken, message, target)
        //connection.disconect

        public Connection Connection(string ipAddress)
        {
            return new Connection();
        }
        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }
        public void Send(AuthToken token, Message message, string target)
        {
            Console.WriteLine(message.Content);
        }
    }
}