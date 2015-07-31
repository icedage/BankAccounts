﻿using BankAccounts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public interface IBankAccountService
    {
        void CreateBankAccount(BankAccountDto bankAccountDto);

        void UpdateBankAccount(BankAccountDto bankAccountDto);

        BankAccountDto GetBankAccount(Guid id);

        void DeleteBankAccount(Guid id);

        IEnumerator<BankAccountDto> GetBankAccounts();
    }
}