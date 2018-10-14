using Core.Domain;
using System;

namespace OrgAccount.Domain
{
    public class OrgReportSummary
    {
        public Orgs Org { get; set; }
        public int BenNum { get; set; }
        public double SalarySum { get; set; }
        public double Dun { get; set; }
        public double TetAO { get; set; }
        public double TetD { get; set; }
        public double TmjAO { get; set; }
        public double TmjD { get; set; }
        public double EmdAO { get; set; }
        public double EmdD { get; set; }
        public double AjlAO { get; set; }
        public double AjlD { get; set; }
        public double YosAO { get; set; }
    }
}
