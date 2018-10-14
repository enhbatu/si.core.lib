using Core.Domain;
using OrgAccount.Domain;
using System;
using System.Collections.Generic;

namespace CoreDomain.Repository
{
    public interface IBenClassRepository
    {
        BenClass GetBenClass(string ID, DateTime date);
        List<BenClass> GetBenClasses();
    }
}
