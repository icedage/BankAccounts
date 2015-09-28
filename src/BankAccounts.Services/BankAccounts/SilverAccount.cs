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
using AccountsAPI.Repository.Repositories;

namespace AccountsAPI.Services.BankAccounts
{
    public class SilverAccount: IRequestAccountHandler
    {
        private IRepository<SilverAccountBenefits> _repository;

        public SilverAccount(IRepository<SilverAccountBenefits> repository)
        {
            _repository = repository;
        }

        public void ProcessRequest(BankAccountBenefits accountBenefits)
        {
            if (accountBenefits.Status == BankAccountStatus.Silver)
            {
                accountBenefits.SilverAccountBenefits.IncludesCheckBook = true;
                accountBenefits.SilverAccountBenefits.IncludesInternetBanking = true;
                accountBenefits.SilverAccountBenefits.Overdraft = new Overdraft()
                {
                    IncludesGracePeriod = true,
                                                                                           IncludesOverdraftBuffer = true,
                                                                                           OverDraftBalance = 100,
                                                                                           PerdayCharges = 1.5m
                                                                                        };
                accountBenefits.SilverAccountBenefits.AABreakdownCover = new AABreakdownCover()
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

                accountBenefits.SilverAccountBenefits.EuropeanTravelInsurance = new EuropeanTravelInsurance()
                {
                    BuggageCover=100,
                    CancellationTravel=200,
                    EmergencyMedicalTravel=50000,
                    PersonalAccidentalCover=50000,
                    TravelDays=30
                };

                accountBenefits.SilverAccountBenefits.IncludesCheckBook = true;
                accountBenefits.SilverAccountBenefits.IncludesInternetBanking = true;
                accountBenefits.SilverAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance()
                {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
                accountBenefits.SilverAccountBenefits.Overdraft = new Overdraft()
                {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

                accountBenefits.SilverAccountBenefits.SentinelCardProtection = new SentinelCardProtection()
                {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };
                _repository.Add(accountBenefits.SilverAccountBenefits);
            }
            else
            {
                Successor.ProcessRequest(accountBenefits);
            }
        }

        public IRequestAccountHandler Successor { get; set; }
    }
}
