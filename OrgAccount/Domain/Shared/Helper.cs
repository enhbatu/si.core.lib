using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgAccount.Domain.Shared
{
    public static class Helper
    {
        public static DateTime YM2Date(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
    }
}
