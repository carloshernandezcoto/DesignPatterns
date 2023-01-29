namespace PatternsApp.Flyweight
{
    public class PointIcon
    {
        private readonly PointType type;
        private readonly byte[] icon;
        public PointType Type => type;
        public PointIcon(PointType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }
    }
}