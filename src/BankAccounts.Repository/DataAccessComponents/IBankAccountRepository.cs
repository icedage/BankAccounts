using BankAccounts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.DataAccessComponents
{
    public interface IBankAccountRepository
    {
        BankAccountDto CreateAccount(CustomerDetailsDto customerDetails);

        void DeleteAccount(Guid accountId);

        void UpdateAccount();

        IEnumerable<BankAccountDto> GetAccounts();

        BankAccountDto GetAccount(Guid account);
    }
}
