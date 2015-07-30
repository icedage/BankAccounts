using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.DataAccessComponents
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public Entities.BankAccountDto CreateAccount(Entities.CustomerDetailsDto customerDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.BankAccountDto> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public Entities.BankAccountDto GetAccount(Guid account)
        {
            throw new NotImplementedException();
        }
    }
}
