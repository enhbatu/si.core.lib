using Core.Domain;
using OrgAccount.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Repository
{
    public interface IAccountRepository
    {
        List<Transac> GetTransacs(string ID);
    }
}
