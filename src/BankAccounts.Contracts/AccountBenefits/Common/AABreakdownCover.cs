using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.AccountBenefits
{
    public class AABreakdownCover
    {
        public bool IncludesRoadSideAssistance { get; set; }

        public bool IncludesAccidentalManagement { get; set; }

        public UpgradeOptions UpgradeOptions { get; set; }   
    }
}
