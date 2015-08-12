using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.AccountBenefits;
using BankAccounts.Services.AccountBenefits.Gold;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.BankAccounts
{
    public class GoldAccount : IRequestAccountHandler
    {
        public IRequestAccountHandler Successor { get; set; }

        public BankAccountBenefits Benefits { get; set; }

        public void ProcessRequest(CustomerDto customer)
        {
            Benefits.GoldAccountBenefits.AABreakdownCover = new AABreakdownCover()
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

            Benefits.GoldAccountBenefits.EuropeanTravelInsurance = new WorldWideTravelInsurance()
            {
                BuggageCover=250,
                CancellationTravel=400,
                EmergencyMedicalTravel=100000,
                IncludesWorldwideCover=true,
                PersonalAccidentalCover=100000,
                TravelDays=45
            };

            Benefits.GoldAccountBenefits.IncludesCheckBook = true;
            Benefits.GoldAccountBenefits.IncludesInternetBanking = true;
            Benefits.GoldAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance() {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
            Benefits.GoldAccountBenefits.Overdraft = new Overdraft() {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    OverdraftBalance = 3000,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

            Benefits.GoldAccountBenefits.SentinelCardProtection = new SentinelCardProtection() {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };
        }
    }
}
