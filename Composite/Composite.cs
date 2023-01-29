namespace PatternsApp.Composite
{
    public class Composite : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Visitor pattern execution..." + Environment.NewLine);

            var group1 = new Group("G1");
            group1.Add(new Shape("Square1"));
            group1.Add(new Shape("Square2"));

            var group2 = new Group("G2");
            group2.Add(new Shape("Circle1"));
            group2.Add(new Shape("Circle2"));

            var group = new Group("G");
            group.Add(group1);
            group.Add(group2);

            group.Render();
            group.Move();

            Console.ReadKey();
        }
    }
}