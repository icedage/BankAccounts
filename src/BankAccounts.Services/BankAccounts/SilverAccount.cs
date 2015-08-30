using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Contracts;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.AccountBenefits;
using BankAccounts.Services.AccountBenefits.Gold;
using BankAccounts.Services.Dtos;
using BankAccounts.Repository;

namespace BankAccounts.Services.BankAccounts
{
    public class SilverAccount: IRequestAccountHandler
    {
        private IRepository<SilverAccountBenefits> _repository;

        public SilverAccount(IRepository<SilverAccountBenefits> repository)
        {
            _repository = repository;
        }

        public BankAccountBenefits Benefits { get; set; }

        public void ProcessRequest(CustomerDto customer)
        {
            if (customer.Status == AccountStatus.Silver)
            {
                Benefits.SilverAccountBenefits.IncludesCheckBook = true;
                Benefits.SilverAccountBenefits.IncludesInternetBanking = true;
                Benefits.SilverAccountBenefits.Overdraft = new Overdraft() {  IncludesGracePeriod = true,
                                                                                           IncludesOverdraftBuffer = true,
                                                                                           OverDraftBalance = 100,
                                                                                           PerdayCharges = 1.5m
                                                                                        };
                Benefits.SilverAccountBenefits.AABreakdownCover = new AABreakdownCover()
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

                Benefits.SilverAccountBenefits.EuropeanTravelInsurance = new EuropeanTravelInsurance()
                {
                    BuggageCover=100,
                    CancellationTravel=200,
                    EmergencyMedicalTravel=50000,
                    PersonalAccidentalCover=50000,
                    TravelDays=30
                };

                Benefits.SilverAccountBenefits.IncludesCheckBook = true;
                Benefits.SilverAccountBenefits.IncludesInternetBanking = true;
                Benefits.SilverAccountBenefits.MobilePhoneInsurance = new MobilePhoneInsurance() {
                                                                                                                MaximumRetailCostCover = 500,
                                                                                                                UnauthorisedCallsForContractsCover = 1000,
                                                                                                                UnauthorisedCallsForPayAsYouGoCover = 300
                                                                                                           };
                Benefits.SilverAccountBenefits.Overdraft = new Overdraft() {
                                                                                    IncludesGracePeriod = true,
                                                                                    IncludesOverdraftBuffer = true,
                                                                                    PerdayCharges = 2.5M
                                                                                  };

                Benefits.SilverAccountBenefits.SentinelCardProtection = new SentinelCardProtection() {
                                                                                                                    Claims = 2500,
                                                                                                                    EmergencyCash = 3000,
                                                                                                                    HotelBillsOverseas = 1500,
                                                                                                                    HouseholdCover = true,
                                                                                                                    IncludesReplacements = true,
                                                                                                                    MedicalAssistanceInAbroad = 300000
                                                                                                                };
                _repository.Add(Benefits.SilverAccountBenefits);
            }
            else
            {
                Successor.ProcessRequest(customer);
            }
        }

        public IRequestAccountHandler Successor { get; set; }
    }
}
