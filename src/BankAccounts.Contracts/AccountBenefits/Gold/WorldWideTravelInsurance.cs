using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.AccountBenefits.Gold
{
    public class WorldWideTravelInsurance
    {
        public bool IncludesWorldwideCover { get; set; }

        public int TravelDays { get; set; }

        public decimal EmergencyMedicalTravel { get; set; }

        public decimal CancellationTravel { get; set; }

        public decimal PersonalAccidentalCover { get; set; }

        public decimal BuggageCover { get; set; }

    }
}
