using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Contracts;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.Dtos;
using AccountsAPI.Services.AccountBenefits.Classic;
using AccountsAPI.Repository;

namespace AccountsAPI.Services.BankAccounts
{
    public class ClassicAccount : IRequestAccountHandler
    {
        private IRepository<ClassicAccountBenefits> _repository;

        public ClassicAccount(IRepository<ClassicAccountBenefits> repository)
        {
            _repository = repository;
        }

        public void ProcessRequest(BankAccountBenefits accountBenefits)
        {
            if (accountBenefits.Status == BankAccountStatus.Classic)
            {
                accountBenefits.ClassicAccountBenefits.IncludesCheckBook = true;
                accountBenefits.ClassicAccountBenefits.IncludesInternetBanking = true;
                accountBenefits.ClassicAccountBenefits.Overdraft = new Overdraft() {
                                                                                        IncludesGracePeriod = false,
                                                                                        IncludesOverdraftBuffer = false,
                                                                                        OverDraftBalance = 35,
                                                                                        PerdayCharges = 1.5m
                                                                                    };
                _repository.Add(accountBenefits.ClassicAccountBenefits);
            }
            else
            {
                Successor.ProcessRequest(accountBenefits);
            }
        }

        public IRequestAccountHandler Successor { get; set; }

    }
}
