using Core.Domain;

namespace OrgAccount.Domain
{
    public class OrgReport
    {
        public Orgs Org { get; set; }
        public Benefic Insuree { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public BenClass BenClass { get; set; }
        public double Salary { get; set; }
        public double RegDate { get; set; }
    }
}
