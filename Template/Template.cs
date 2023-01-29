namespace PatternsApp.Template
{
    public class Template : IPattern
    {
        public void Execute()
        {
            PrintAppMsg.Print("Starting Template pattern execution..." + Environment.NewLine);

            var auditTrail = new FileAuditTrail();
            var transferMoney = new TransferMoney(auditTrail);
            var generateReport = new GenerateReport(auditTrail);
            transferMoney.Execute();
            generateReport.Execute();
            Console.ReadKey();
        }
    }
}