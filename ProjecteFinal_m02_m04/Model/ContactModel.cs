namespace ProjecteFinal_m02_m04.Model
{
    public class ContactModel
    {
        private int contactId;
        private int customerId;
        private String name;
        private String email;
        private String phone;
        private String company;

        // Array contactList format per ContactModels
        private static List<ContactModel> contactList = new List<ContactModel>();

        public int ContactId { get => contactId; set => contactId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public String Name { get => name; set => name = value; }
        public String Email { get => email; set => email = value; }
        public String Phone { get => phone; set => phone = value; }
        public String Company { get => company; set => company = value; }

        // Afegir contact de tipus ContactModel, a ArrayList contactList.
        public void addContact(ContactModel contact)
        {
            contactList.Add(contact);
        }

    }
}
