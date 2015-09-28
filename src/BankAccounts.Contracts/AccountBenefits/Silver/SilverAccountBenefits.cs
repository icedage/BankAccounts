using AccountsAPI.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.AccountBenefits
{
    public class SilverAccountBenefits
    {
        public int AccountId { get; set; }

        public bool IncludesInternetBanking {get;set;}

        public bool IncludesCheckBook { get; set; }

        public EuropeanTravelInsurance EuropeanTravelInsurance { get; set; }

        public AABreakdownCover AABreakdownCover { get; set; }

        public MobilePhoneInsurance MobilePhoneInsurance { get; set; }

        public Overdraft Overdraft { get; set; }

        public SentinelCardProtection SentinelCardProtection {get;set;}
    }
}
