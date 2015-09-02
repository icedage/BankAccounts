using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.AccountBenefits
{
    public class AABreakdownCover
    {
        public bool IncludesRoadSideAssistance { get; set; }

        public bool IncludesAccidentalManagement { get; set; }

        public UpgradeOptions UpgradeOptions { get; set; }   
    }
}
