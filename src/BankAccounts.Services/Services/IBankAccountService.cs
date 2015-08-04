using BankAccounts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.Services
{
    public interface IBankAccountService
    {
        void CreateBankAccount(CustomerDto bankAccountDto);

        void UpdateBankAccount(CustomerDto bankAccountDto);

        BankAccountDto GetBankAccount(Guid id);

        void DeleteBankAccount(Guid id);

        IEnumerator<BankAccountDto> GetBankAccounts();
    }
}
