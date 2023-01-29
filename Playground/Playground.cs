namespace PatternsApp.Playground
{
    public class Playground : IPattern
    {

        public void Execute()
        {
            PrintAppMsg.Print("Starting Playground app..." + Environment.NewLine);

            //Testing how static properties work...
            System.Console.WriteLine("Static number = {0}", StaticTest.StaticNumber);
            StaticTest.StaticNumber = 7;

            var instance = new StaticTest();

            //System.Console.WriteLine("Instance tatic number = {0}", instance.StaticNumber);

            Console.ReadKey();
        }
    }

    public class StaticTest
    {
        private static int staticNumber;
        private int nonStaticNumber;

        public StaticTest()
        { }

        public static int StaticNumber { get => staticNumber; set => staticNumber = value; }
        public int NonStaticNumber { get => nonStaticNumber; set => nonStaticNumber = value; }

        public static string StaticMethod()
        {
            return "This is a static method.";
        }
    }
}