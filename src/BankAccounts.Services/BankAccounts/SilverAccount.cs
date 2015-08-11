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
    public class SilverAccount: BankAccountStatusApprover
    {
        private BankAccountBenefits _bankAccountApproval;

        public SilverAccount()
        {
            _bankAccountApproval = new BankAccountBenefits();
        }

        public override BankAccountBenefits ProcessRequest(CustomerDto bankAccountApproval)
        {
            if(bankAccountApproval.AnnualGrossSalary >= 30000 || bankAccountApproval.AnnualGrossSalary < 65000)
            {
                _bankAccountApproval.SilverAccountBenefits.IncludesCheckBook = true;
                _bankAccountApproval.SilverAccountBenefits.IncludesInternetBanking = true;
                _bankAccountApproval.SilverAccountBenefits.Overdraft = new Overdraft() {  IncludesGracePeriod = true,
                                                                                           IncludesOverdraftBuffer = true,
                                                                                           OverDraftBalance = 100,
                                                                                           PerdayCharges = 1.5m
                                                                                        };
            _bankAccountApproval.SilverAccountBenefits.AABreakdownCover = new AABreakdownCover()
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

            _bankAccountApproval.SilverAccountBenefits.EuropeanTravelInsurance = new EuropeanTravelInsurance()
            {
                BuggageCover=100,
                CancellationTravel=200,
                EmergencyMedicalTravel=50000,
                PersonalAccidentalCover=50000,
                TravelDays=30
            };

            _bankAccountApproval.SilverAccountBenefits.IncludesCheckBook = true;
            _bankAccountApproval.SilverAccountBenefits.IncludesInternetBanking = true;
            _bankAccountApproval.SilverAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance() {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
            _bankAccountApproval.SilverAccountBenefits.Overdraft = new Overdraft() {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    OverdraftBalance = 3000,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

            _bankAccountApproval.SilverAccountBenefits.SentinelCardProtection = new SentinelCardProtection() {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };
            }
            else
            {
                _bankAccountApproval = this._successor.ProcessRequest(bankAccountApproval);
            }
            return _bankAccountApproval;
        }
    }
}
