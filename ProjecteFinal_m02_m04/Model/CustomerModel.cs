using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteFinal_m02_m04.Model
{
    public class CustomerModel
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private string address;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

    }
}
