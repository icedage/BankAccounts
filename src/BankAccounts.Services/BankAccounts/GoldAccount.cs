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
    public class GoldAccount : BankAccountStatusApprover
    {
        private BankAccountBenefits _bankAccountApproval;

        public GoldAccount()
        {
            _bankAccountApproval = new BankAccountBenefits();
        }

        public override BankAccountBenefits ProcessRequest(CustomerDto customer)
        {
            _bankAccountApproval.GoldAccountBenefits.AABreakdownCover = new AABreakdownCover()
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

            _bankAccountApproval.GoldAccountBenefits.EuropeanTravelInsurance = new WorldWideTravelInsurance()
            {
                BuggageCover=250,
                CancellationTravel=400,
                EmergencyMedicalTravel=100000,
                IncludesWorldwideCover=true,
                PersonalAccidentalCover=100000,
                TravelDays=45
            };

            _bankAccountApproval.GoldAccountBenefits.IncludesCheckBook = true;
            _bankAccountApproval.GoldAccountBenefits.IncludesInternetBanking = true;
            _bankAccountApproval.GoldAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance() {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
            _bankAccountApproval.GoldAccountBenefits.Overdraft = new Overdraft() {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    OverdraftBalance = 3000,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

            _bankAccountApproval.GoldAccountBenefits.SentinelCardProtection = new SentinelCardProtection() {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };

            return _bankAccountApproval;
        }
    }
}
