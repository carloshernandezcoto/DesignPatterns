namespace PatternsApp.Bridge
{
    public class SonyTv : IDevice
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine("Sony set channel...");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Sony turn off...");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Sony turn on...");
        }
    }
}