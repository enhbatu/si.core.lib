using Account.Adapter;
using Core.Domain;
using CoreDomain.Repository;
using OrgAccount.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrgAccount.Domain
{
    public class OrgReportAdapter
    {
        private OrgReportAdapter _orgReportAdapter;
        private IBenClassRepository _benClassRepository;

        public OrgReportAdapter(OrgReportAdapter orgReportAdapter, IBenClassRepository benClassRepository)
        {
            _orgReportAdapter = orgReportAdapter;
            _benClassRepository = benClassRepository;
        }
        public OrgBalance CalcBalance(OrgBalance orgBalanceBefore, List<OrgReportFee> report, List<Transac> transacs, double Zal)
        {
            var balance = new OrgBalance();
            balance.Org = orgBalanceBefore.Org;            
            balance.CalYear = Helper.YM2Date(orgBalanceBefore.CalYear, orgBalanceBefore.CalMonth).AddMonths(1).Year;
            balance.CalMonth = Helper.YM2Date(orgBalanceBefore.CalYear, orgBalanceBefore.CalMonth).AddMonths(1).Month;
            balance.C1 = orgBalanceBefore.C2;
            balance.Income = transacs.Sum(t => t.Dun);
            balance.Outcome = report.Sum(r => r.Dun) + Zal;
            return balance;
        }
        public OrgReportFee CalcFee(OrgReport report)
        {
            var BenClass = _benClassRepository.GetBenClass(report.BenClass.ID, Helper.YM2Date(report.Year, report.Month));
            var fee = new OrgReportFee();
            fee.Report = report;
            fee.Dun = report.Salary * BenClass.Total / 100;
            return fee;
        }
        public OrgReportFee CalcReportEditDiff(OrgReportFee reportOld, OrgReportFee reportNew)
        {
            return new OrgReportFee()
            {
                Report = reportNew.Report,
                Dun = reportNew.Dun - reportOld.Dun,
                TetAO = reportNew.TetAO - reportOld.TetAO,
                TetD = reportNew.TetD - reportOld.TetD,
                TmjAO = reportNew.TmjAO - reportOld.TmjAO,
                TmjD = reportNew.TmjD - reportOld.TmjD,
                EmdAO = reportNew.EmdAO - reportOld.EmdAO,
                EmdD = reportNew.EmdD - reportOld.EmdD,
                AjlAO = reportNew.AjlAO - reportOld.AjlAO,
                AjlD = reportNew.AjlD - reportOld.AjlD,
                YosAO = reportNew.YosAO - reportOld.YosAO
            };
        }
        public OrgReportSummary CalcSummary(List<OrgReportFee> report)
        {
            var summary = new OrgReportSummary();
            if (report != null && report.Count > 0)
            {
                summary.Org = report[0].Report.Org;
                summary.BenNum = report.Count;
            }
            foreach (var r in report)
            {
                summary.SalarySum = summary.SalarySum + r.Report.Salary;
                summary.Dun = summary.Dun + r.Dun;
                summary.TetAO = summary.TetAO + r.TetAO;
                summary.TetD = summary.TetD + r.TetD;
                summary.TmjAO = summary.TmjAO + r.TmjAO;
                summary.TmjD = summary.TmjD + r.TmjD;
                summary.EmdAO = summary.EmdAO + r.EmdAO;
                summary.EmdD = summary.EmdD + r.EmdD;
                summary.AjlAO = summary.AjlAO + r.AjlAO;
                summary.AjlD = summary.AjlD + r.AjlD;
                summary.YosAO = summary.YosAO + r.YosAO;
            }
            return summary;
        }
    }
}
