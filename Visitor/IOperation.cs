namespace PatternsApp.Visitor
{
    public interface IOperation
    {
        public void Apply(HeadingNode heading);
        public void Apply(AnchorNode anchor);
    }
}