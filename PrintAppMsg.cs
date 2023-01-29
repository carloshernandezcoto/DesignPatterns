namespace PatternsApp
{
    public static class PrintAppMsg
    {
        public static void Print(string message)
        {
            var currentFGColor = Console.ForegroundColor;
            var currentBGColor = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ForegroundColor = currentFGColor;
            Console.BackgroundColor = currentBGColor;

        }
    }
}