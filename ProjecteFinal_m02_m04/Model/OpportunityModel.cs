namespace ProjecteFinal_m02_m04.Model
{
    public class OpportunityModel
    {
        private int opportunityId;
        private int customerId;
        private int amount;
        private String status;

        // Array opportunityList format per OpportunityModels
        private static List<OpportunityModel> opportunityList = new List<OpportunityModel>();


        public int OpportunityId { get => opportunityId; set => opportunityId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int Amount { get => amount; set => amount = value; }
        public String Status { get => status; set => status = value; }

        // Afegir opportunity de tipus OpportunityModel, a ArrayList opportunityList.
        public void addOpportunity(OpportunityModel opportunity)
        {
            opportunityList.Add(opportunity);
        }
    }
}
