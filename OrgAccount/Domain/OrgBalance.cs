using Core.Domain;
using System;

namespace OrgAccount.Domain
{
    public class OrgBalance 
    {
        public Orgs Org { get; set; }
        public int CalYear { get; set; }
        public int CalMonth { get; set; }
        public double C1 { get; set; }
        public double Income { get; set; }
        public double Outcome { get; set; }
        public double C2 { get
            {
                return C1 + Income - Outcome;
            }
        }
    }
}
