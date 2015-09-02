using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Repository.Repositories;
using AccountsAPI.Services.BankAccounts;
using AccountsAPI.Repository;
using AccountsAPI.Services.Dtos;
using AccountsAPI.Contracts;
using AccountsAPI.Services.AccountBenefits.Gold;

namespace AccountsAPI.Services.Services
{
    public class AccountService : IAccountService
    {
        private IAccountDetailsService _accountDetailsService;
        private IRepository<Account> _accountsRepository;
        private ICreditReportService _creditReportService;

        public AccountService(IAccountDetailsService accountDetailsService, IRepository<Account> accountsRepository, ICreditReportService creditReportService)
        {
            _accountDetailsService = accountDetailsService;
            _accountsRepository = accountsRepository;
            _creditReportService = creditReportService;
        }

        public async Task<AccountDto> CreateAccount(CustomerDto customer)
        {
            //Account Credentials
            var accountDetails = _accountDetailsService.GetAccount();
            
            var account = new Account()
            {
                CustomerId = customer.CustomerId,
                AccountNumber = accountDetails.AccountNumber,
                SortCode = accountDetails.SortCode
            };

            var accountStatus = await GetAccountStatus(customer);

            if (accountStatus != AccountStatus.Denied)
            {
                var accountId = _accountsRepository.Add(account);

                return new AccountDto
                {
                    AccountId = accountId,
                    AccountNumber = account.AccountNumber,
                    SortCode = account.SortCode,
                    CustomerId = customer.CustomerId
                };
            }

            return new AccountDto() { Status = AccountStatus.Denied };
        }

        //Service to retrieve credit report
        private async Task<AccountStatus> GetAccountStatus(CustomerDto customer)
        {
            var accountStatus = AccountStatus.Denied;
            try
            {
                var report = await _creditReportService.GetCreditReport(customer);

                if (report.CreditReport.IsEligible)
                {
                    if (customer.AnnualGrossSalary < 20000)
                        accountStatus = AccountStatus.Classic;
                    if (customer.AnnualGrossSalary >= 20000 && customer.AnnualGrossSalary < 40000)
                        accountStatus = AccountStatus.Silver;
                    if (customer.AnnualGrossSalary >= 40000)
                        accountStatus = AccountStatus.Gold;
                }

                return accountStatus;
            }
            catch (Exception ex)
            {

                return accountStatus;
            }
        }
    }
}
