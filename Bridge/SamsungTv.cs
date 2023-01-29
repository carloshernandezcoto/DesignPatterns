namespace PatternsApp.Bridge
{
    public class SamsungTv : IDevice
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine("Samsung set channel...");
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