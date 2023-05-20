namespace ProjecteFinal_m02_m04.Model
{
    public class CustomerModel
    {
        private int customerId;
        private string name;
        private string email;
        private string phone;
        private string address;

        // Array customerList format per CustomerModels
        private static List<CustomerModel> customerList = new List<CustomerModel>();

        public int Id { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        // Afegir customer de tipus CustomerModel, a ArrayList customerList.
        public void addCustomer(CustomerModel customer)
        {
            customerList.Add(customer);
        }
    }
}
