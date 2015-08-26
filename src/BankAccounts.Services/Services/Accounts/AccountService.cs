using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Repository.Repositories;
using BankAccounts.Services.BankAccounts;
using BankAccounts.Repository;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.Services
{
    public class AccountService : IAccountService
    {
        private IAccountDetailsService _accountDetailsService;
        private IRepository<Account> _accountsRepository;

        public AccountService(IAccountDetailsService accountDetailsService, IRepository<Account> accountsRepository)
        {
            _accountDetailsService = accountDetailsService;
            _accountsRepository = accountsRepository;
        }

        public AccountDto CreateAccount(CustomerDto customer)
        {
            //Account Credentials
            var accountDetails = _accountDetailsService.GetAccount();

            ////Benefits
            //var handler = ChainOfAccountsInitializer();
            //handler.ProcessRequest(customer);
            //var benefits = handler.Benefits;

            var account = new Account()
            {
                CustomerId = customer.CustomerId,
                AccountNumber = accountDetails.AccountNumber,
                SortCode = accountDetails.SortCode
            };

            //Repository
            var accountId = _accountsRepository.Add(account);

            return new AccountDto {     AccountId=accountId,
                                        AccountNumber=account.AccountNumber,
                                        SortCode=account.SortCode,
                                        CustomerId=customer.CustomerId};
        }

        private IRequestAccountHandler ChainOfAccountsInitializer()
        {
            IRequestAccountHandler account = new GoldAccount();
            var silverAccount = new SilverAccount(){ Successor = account};
            var classicAccount = new ClassicAccount() { Successor = silverAccount};
            return account;
        }
    }
}
