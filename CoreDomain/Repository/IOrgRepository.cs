using Core.Domain;
using OrgAccount.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDomain.Repository
{
    public interface IOrgRepository
    {
        Orgs GetOrg(string ID);
    }
}
