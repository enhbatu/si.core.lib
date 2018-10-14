using Core.Domain;
using System;

namespace OrgAccount.Domain
{
    public class OrgPayment
    {
        public Orgs Org { get; set; }
        public DateTime RegDate { get; set; }
        public double Transac { get; set; }
    }
}
