using Core.Domain;
using OrgAccount.Domain;
using System;
using System.Collections.Generic;
using System.Linq;


namespace OrgAccount.Repository
{
    public interface IOrgAccountRepository
    {
        List<OrgReport> OrgReportList(string ID);
        List<OrgReportFee> OrgReportFeeList(string ID);
    }
}
