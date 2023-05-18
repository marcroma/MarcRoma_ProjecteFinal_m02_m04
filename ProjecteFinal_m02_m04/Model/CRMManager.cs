using System.Xml;

namespace ProjecteFinal_m02_m04.Model
{
    // Encarregat d'emmagatzemar les dades de l'XML.
    public static class CRMManager
    {
        private static String message = String.Empty;

        private static List<CustomerModel> customerList = new List<CustomerModel>();

        private static List<OpportunityModel> opportunityList = new List<OpportunityModel>();

        private static List<ContactModel> contactList = new List<ContactModel>();

        public static bool loadXML(String filePath)
        {
            bool bres = false;

            try
            {
                //if (DTDValidator.Validate(filePath))
                //{
                XmlDocument docCRM = new XmlDocument();
                docCRM.Load(filePath);
                XmlNodeList CustomerElements = docCRM.SelectNodes("//customers");

                foreach (XmlNode customer in CustomerElements)
                {
                    CustomerModel Customer = new CustomerModel();

                    Customer.Id = int.Parse(customer.Attributes["id"].InnerText);
                    Customer.Name = customer.SelectSingleNode("name").InnerText;
                    Customer.Email = customer.SelectSingleNode("email").InnerText;
                    Customer.Phone = customer.SelectSingleNode("phone").InnerText;
                    Customer.Address = $"{customer.Attributes["street"]?.InnerText}, {customer.Attributes["city"]?.InnerText}, {customer.Attributes["state"]?.InnerText}, {customer.Attributes["zipcode"]?.InnerText}";

                    customerList.Add(Customer);
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
