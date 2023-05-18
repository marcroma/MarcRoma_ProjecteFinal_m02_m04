using System.Xml;

namespace ProjecteFinal_m02_m04.Model
{
    // Encarregat d'emmagatzemar les dades de l'XML.
    public static class CRMManager
    {
        private static List<CustomerModel> customerList = new List<CustomerModel>();

        private static List<OpportunityModel> opportunityList = new List<OpportunityModel>();

        private static List<ContactModel> contactList = new List<ContactModel>();

        public static bool loadModel(String filePath)
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
                    CustomerModel Customer = new CustomerModel()
                    {
                        Id = int.Parse(customer.Attributes["id"].InnerText),
                        Name = customer.SelectSingleNode("name").InnerText,
                        Email = customer.SelectSingleNode("email").InnerText,
                        Phone = customer.SelectSingleNode("phone").InnerText,
                        Address = customer.Attributes["street", "city", "state", "zipcode"].InnerText
                    };
                }
                //}
            }
            catch
            {

            }
            return bres;
        }
    }
}
