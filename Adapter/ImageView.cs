namespace PatternsApp.Adapter
{
    public class ImageView
    {
        private Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }
        public void ApplyFilter(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}