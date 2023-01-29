namespace PatternsApp.Template
{
    public abstract class Task
    {
        private IAuditTrail auditTrail;
        protected string logData;

        protected Task(IAuditTrail auditTrail)
        {
            this.logData = "No available data";
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record(logData);
            doExecute();
        }

        protected abstract void doExecute();
    }
}