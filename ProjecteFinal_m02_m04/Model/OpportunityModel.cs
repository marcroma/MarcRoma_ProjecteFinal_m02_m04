using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteFinal_m02_m04.Model
{
    public class OpportunityModel
    {
        private int customerId;
        private int amount;
        private String status;


        public int CustomerId { get => customerId; set => customerId = value; }
        public int Amount { get => amount; set => amount = value; }
        public String Status { get => status; set => status = value; }
    }
}
