namespace PatternsApp.Observer
{
    public class Observer : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Observer pattern execution..." + Environment.NewLine);

            var ds1 = new DataSource();
            var ds2 = new DataSource();
            var sheet1 = new Spreadsheet(ds1);
            var sheet2 = new Spreadsheet(ds2);
            var ch1 = new Chart(ds1);

            ds1.Subscribe(sheet1);
            ds1.Subscribe(ch1);
            ds2.Subscribe(sheet2);

            ds1.Value = 1;
            ds2.Value = 2;
            ds1.Value = 5;
            ds2.Value = 10;

            Console.ReadKey();
        }
    }
}