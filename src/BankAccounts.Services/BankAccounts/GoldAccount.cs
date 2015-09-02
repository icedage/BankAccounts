using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Contracts;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.AccountBenefits;
using AccountsAPI.Services.AccountBenefits.Gold;
using AccountsAPI.Services.Dtos;
using AccountsAPI.Repository;

namespace AccountsAPI.Services.BankAccounts
{
    public class GoldAccount : IRequestAccountHandler
    {
        private IRepository<GoldAccountBenefits> _repository;

        public GoldAccount(IRepository<GoldAccountBenefits> repository)
        {
            _repository = repository;
        }

        public IRequestAccountHandler Successor { get; set; }

        public void ProcessRequest(BankAccountBenefits accountBenefits)
        {
            accountBenefits.GoldAccountBenefits.AABreakdownCover = new AABreakdownCover()
            {
                IncludesAccidentalManagement = true,
                IncludesRoadSideAssistance = true,
                UpgradeOptions = new UpgradeOptions()
                    {
                        HomeStart = true,
                        IncludesRelay = true,
                        IncludesStayMobile = true
                    }
            };

            accountBenefits.GoldAccountBenefits.EuropeanTravelInsurance = new WorldWideTravelInsurance()
            {
                BuggageCover=250,
                CancellationTravel=400,
                EmergencyMedicalTravel=100000,
                IncludesWorldwideCover=true,
                PersonalAccidentalCover=100000,
                TravelDays=45
            };

            accountBenefits.GoldAccountBenefits.IncludesCheckBook = true;
            accountBenefits.GoldAccountBenefits.IncludesInternetBanking = true;
            accountBenefits.GoldAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance() {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
            accountBenefits.GoldAccountBenefits.Overdraft = new Overdraft()
            {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

            accountBenefits.GoldAccountBenefits.SentinelCardProtection = new SentinelCardProtection()
            {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };
            _repository.Add(accountBenefits.GoldAccountBenefits);
        }
    }
}
