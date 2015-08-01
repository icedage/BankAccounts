using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.Services
{
    public class BankAccountService : IBankAccountService
    {
        public void CreateBankAccount(CustomerDto bankAccountDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateBankAccount(CustomerDto bankAccountDto)
        {
            throw new NotImplementedException();
        }

        public BankAccountDto GetBankAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteBankAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<BankAccountDto> GetBankAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
