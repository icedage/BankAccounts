using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Repository.Repositories;
using BankAccounts.Services.BankAccounts;

namespace BankAccounts.Services.Services
{
    public class AccountService : IAccountService
    {
        private IAccountDetailsService _accountDetailsService;
        private IAccountsRepository _accountsRepository;

        public AccountService(IAccountDetailsService accountDetailsService, IAccountsRepository accountsRepository)
        {
            _accountDetailsService = accountDetailsService;
            _accountsRepository = accountsRepository;
        }

        public void CreateAccount(CustomerDto customer)
        {
            //Account Credentials
            var accountDetails = _accountDetailsService.GetAccount();

            //Benefits
            var handler = ChainOfAccountsInitializer();
            handler.ProcessRequest(customer);
            var benefits = handler.Benefits;

            var account = new Account() {   CustomerId=customer.CustomerId,
                                            AccountNumber=accountDetails.AccountNumber,
                                            SortCode= accountDetails.SortCode
                                        };

            //Repository
            _accountsRepository.CreateAccount(account);
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
