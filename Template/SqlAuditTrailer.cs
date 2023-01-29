namespace PatternsApp.Template
{
    public class SqlAuditTrailer : IAuditTrail
    {
        public void Record(string data)
        {
            var originalConsoleFGColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Environment.NewLine + "Logging the following audit data in a SQL DB --> {0}", data);
            Console.ForegroundColor = originalConsoleFGColor;

        }
    }
}