namespace PatternsApp.Prototype
{
    public class Circle : IComponent
    {
        private int radius;
        private string name;

        public Circle(int radius, string name)
        {
            this.radius = radius;
            this.name = name;
        }

        public int Radius { get => radius; set => radius = value; }
        public string Name { get => name; set => name = value; }

        public IComponent Clone()
        {
            var random = new Random();
            return new Circle(radius, string.Concat("Circle", random.Next(1, 1000000)));
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering circle {0}...", name);
        }
    }
}