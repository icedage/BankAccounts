using AccountsAPI.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.AccountBenefits.Gold
{
    public class GoldAccountBenefits
    {
        public bool IncludesInternetBanking {get;set;}

        public bool IncludesCheckBook { get; set; }

        public WorldWideTravelInsurance EuropeanTravelInsurance { get; set; }

        public AABreakdownCover AABreakdownCover { get; set; }

        public MobilePhoneInsurance MobilePhoneInsurance { get; set; }

        public Overdraft Overdraft { get; set; }

        public SentinelCardProtection SentinelCardProtection { get; set; }
    }
}
