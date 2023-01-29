namespace PatternsApp.Flyweight
{
    public class PointIconFactory
    {
        private IDictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
                icons.Add(type, new PointIcon(type, null));
            return icons[type];
        }
    }
}