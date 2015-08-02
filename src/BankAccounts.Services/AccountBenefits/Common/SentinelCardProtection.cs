using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.AccountBenefits
{
    public class SentinelCardProtection
    {
        public decimal EmergencyCash { get; set; }

        public decimal HotelBillsOverseas { get; set; }

        public decimal Claims { get; set; }

        public decimal MedicalAssistanceInAbroad { get; set; }

        public bool IncludesReplacements { get; set; }

        public bool HouseholdCover { get; set; }
    }
}
