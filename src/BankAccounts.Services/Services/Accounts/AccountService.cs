using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.BankAccounts;

namespace BankAccounts.Services.Services
{
    public class AccountService : IAccountService
    {
        private IAccountDetailsService _accountDetailsService;

        public AccountService(IAccountDetailsService accountDetailsService)
        {
            _accountDetailsService = accountDetailsService;
        }

        public void CreateAccount(CustomerDto customer)
        {
            //Account Credentials
            var accountDetails = _accountDetailsService.GetAccount();

            //Benefits
            var handler = ChainOfAccountsInitializer();
            handler.ProcessRequest(customer);
            var benefits = handler.Benefits;

            //Repository
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
