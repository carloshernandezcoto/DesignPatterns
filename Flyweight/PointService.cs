namespace PatternsApp.Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, iconFactory.GetPointIcon(PointType.CAFE));
            points.Add(point);
            return points;
        }
    }
}