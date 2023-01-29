using PatternsApp.Command.fx;

namespace PatternsApp.Command.app
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService customerService;
        private string name = "Add Customer";
        public string Name { get => name; }
        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}