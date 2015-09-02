using AccountsAPI.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Services
{
    public class AccountDetailsService : IAccountDetailsService
    {
        public AccountDto GetAccount()
        {
            var account = new AccountDto();
            var generator = CodeGenerator.Instance;
            generator.GenerateSortCode();

            Parallel.Invoke(() =>
                                 {
                                     account.AccountNumber = generator.GenerateAccountNumber();
                                 },
                                 () =>
                                 {
                                     account.SortCode = generator.GenerateSortCode();
                                 }
                           );
            return account;
        }
    }
}
