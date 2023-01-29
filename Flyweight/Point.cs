namespace PatternsApp.Flyweight
{
    public class Point
    {
        private int x;
        private int y;
        private PointIcon icon;

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2})", icon.Type, x, y);
        }
    }
}