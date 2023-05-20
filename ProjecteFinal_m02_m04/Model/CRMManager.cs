using System.Xml;

namespace ProjecteFinal_m02_m04.Model
{
    // Encarregat d'emmagatzemar les dades de l'XML.
    public static class CRMManager
    {
        // Missatge a mostrar en cas d'error.
        private static String message = String.Empty;

        // === ARRAYLISTS ===

        // Crear ArrayList customerList format per CustomerModels.
        private static List<CustomerModel> customerList = new List<CustomerModel>();

        // Crear ArrayList contactList format per ContactsModels.
        private static List<ContactModel> contactList = new List<ContactModel>();

        // Crear ArrayList opportunityList format per OpportunityModels.
        private static List<OpportunityModel> opportunityList = new List<OpportunityModel>();

        // ===


        // === LOAD XML ===
        public static bool loadXML(String filePath)
        {
            bool bres = false;

            try
            {
                //if (DTDValidator.Validate(filePath))
                //{
                XmlDocument docCRM = new XmlDocument();

                // Carregar fitxer de ruta obtinguda en OpenDialog.
                docCRM.Load(filePath);

                // On trobar els elements dins l'XML amb ruta XPATH.
                XmlNodeList CustomerElements = docCRM.SelectNodes("//customers");
                XmlNodeList OpportunityElements = docCRM.SelectNodes("//opportunities");
                XmlNodeList ContactElements = docCRM.SelectNodes("//contacts");

                // Per cada element CUSTOMER que es trobi dins l'XML ...
                foreach (XmlNode customer in CustomerElements)
                {
                    // Es crea un nou Customer tipus CustomerModel
                    CustomerModel Customer = new CustomerModel();

                    // Emplenar camps Customer
                    Customer.Id = int.Parse(customer.Attributes["customerId"].InnerText);
                    Customer.Name = customer.SelectSingleNode("name").InnerText;
                    Customer.Email = customer.SelectSingleNode("email").InnerText;
                    Customer.Phone = customer.SelectSingleNode("phone").InnerText;
                    Customer.Address = $"{customer.Attributes["street"]?.InnerText}, {customer.Attributes["city"]?.InnerText}, {customer.Attributes["state"]?.InnerText}, {customer.Attributes["zipcode"]?.InnerText}";

                    // Afegir customer plè a Array customerList
                    customerList.Add(Customer);
                }

                // Per cada element CONTACT que es trobi dins l'XML ...
                foreach (XmlNode contact in ContactElements)
                {
                    // Es crea un nou Contact tipus ContactModel
                    ContactModel Contact = new ContactModel();

                    // Emplenar camps Contact
                    Contact.ContactId = int.Parse(contact.Attributes["customerId"].InnerText);
                    Contact.CustomerId = int.Parse(contact.SelectSingleNode("customerId").InnerText);
                    Contact.Name = contact.SelectSingleNode("name").InnerText;
                    Contact.Email = contact.SelectSingleNode("email").InnerText;
                    Contact.Phone = contact.SelectSingleNode("phone").InnerText;
                    Contact.Company = contact.SelectSingleNode("company").InnerText;

                    // Afegir contacte plè a Arrat contactList
                    contactList.Add(Contact);
                }

                // Per cada element OPPORTUNITY que es trobi dins l'XML ...
                foreach (XmlNode opportunity in OpportunityElements)
                {
                    // Es crea una nova Opportunity tipus OpportunityModel
                    OpportunityModel Opportunity = new OpportunityModel();

                    // Emplenar camps Opportunity
                    Opportunity.OpportunityId = int.Parse(opportunity.Attributes["customerId"].InnerText);
                    Opportunity.CustomerId = int.Parse(opportunity.SelectSingleNode("customerId").InnerText);
                    Opportunity.Amount = int.Parse(opportunity.SelectSingleNode("amount").InnerText);
                    Opportunity.Status = opportunity.SelectSingleNode("status").InnerText;

                    // Afegir opportunity plena a Array opportunityList
                    opportunityList.Add(Opportunity);

                }

                //}
            }
            catch
            {
                message = "El fitxer XML no s'ha pogut carregar.";
            }
            return bres;
        }
    }
}
