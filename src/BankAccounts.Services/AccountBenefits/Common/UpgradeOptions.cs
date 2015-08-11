using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.AccountBenefits
{
    public class UpgradeOptions
    {
        public bool IncludesRelay { get; set; }

        public bool IncludesStayMobile { get; set; }

        public bool HomeStart { get; set; }
    }
}
