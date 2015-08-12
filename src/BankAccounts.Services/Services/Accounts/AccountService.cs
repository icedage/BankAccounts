using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public class AccountService : IAccountService
    {
        IAccountDetailsService _accountDetailsService;

        public AccountService(IAccountDetailsService accountDetailsService)
        {
            _accountDetailsService = accountDetailsService;
        }

        public void CreateAccount(int customerId)
        {
            var accountDetails = _accountDetailsService.GetAccount();

            //Repository
        }
    }
}
