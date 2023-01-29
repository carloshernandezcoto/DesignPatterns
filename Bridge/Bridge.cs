namespace PatternsApp.Bridge
{
    public class Bridge : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Bridge pattern execution..." + Environment.NewLine);

            var remoteControl = new RemoteControl(new SonyTv());
            remoteControl.TurnOn();

            var advancedRemoteControl = new AdvancedRemoteControl(new SonyTv());
            advancedRemoteControl.SetChannel(4);

            Console.ReadKey();
        }
    }
}