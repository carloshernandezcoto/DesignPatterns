namespace PatternsApp.Template
{
    public class TransferMoney : Task
    {
        public TransferMoney(IAuditTrail auditTrail) : base(auditTrail)
        {
            logData = "Sender: Carlos, Amount: 100";
        }

        protected override void doExecute()
        {
            Console.WriteLine("Transfering money...");
        }
    }
}