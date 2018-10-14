using System;

namespace Core.Domain
{
    public class BenClass
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double TetAO { get; set; }
        public double TetD { get; set; }
        public double TmjAO { get; set; }
        public double TmjD { get; set; }
        public double EmdAO { get; set; }
        public double EmdD { get; set; }
        public double AjlAO { get; set; }
        public double AjlD { get; set; }
        public double YosD { get; set; }
        public double Total
        {
            get
            {
                return TetAO + TetD + TmjAO + TmjD + EmdAO + EmdD + AjlAO + AjlD + YosD;
            }
        }
        public DateTime StartDate { get; set; }
    }
}
