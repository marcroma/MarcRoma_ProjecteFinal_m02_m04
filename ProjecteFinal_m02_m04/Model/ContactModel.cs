using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteFinal_m02_m04.Model
{
    public class ContactModel
    {
        private int customerId;
        private String name;
        private String email;
        private String phone;
        private String company;

        public int CustomerId { get =>  customerId; set => customerId = value;}
        public String Name { get => name; set => name = value;}
        public String Email { get => email; set => email = value;}
        public String Phone { get => phone; set => phone = value;}
        public String Company { get => company; set => company = value;}



    }
}
