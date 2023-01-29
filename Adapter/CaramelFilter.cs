namespace PatternsApp.Adapter
{
    public class CaramelFilter : IFilter
    {
        private CaramelFX caramelFx;

        public CaramelFilter(CaramelFX caramelFx)
        {
            this.caramelFx = caramelFx;
        }

        public void Apply(Image image)
        {
            caramelFx.Init();
            caramelFx.Render(image);
        }
    }
}