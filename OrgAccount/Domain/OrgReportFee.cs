using System;

namespace OrgAccount.Domain
{
    public class OrgReportFee
    {
        public OrgReport Report { get; set; }
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
