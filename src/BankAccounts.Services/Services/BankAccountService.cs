using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.BankAccounts;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.Services
{
    public class BankAccountService : IBankAccountService
    {
        private IBankAccountLevelApprover _bankAccountLevelApprover;

        public BankAccountService(IBankAccountLevelApprover bankAccountLevelApprover)
        {
            _bankAccountLevelApprover = bankAccountLevelApprover;
        }

        public void CreateBankAccount(CustomerDto customer)
        {
            //You call TiresiasAPI
            //You save Customer and retrieve CustomerId

            //Call Generator amd retrieve BankAccountId
            //You Save the Bank Account

            //You Call the COR for Account Level and benefits
            //You save it.
            IBankAccountLevelApprover classicAccount = new ClassicAccount();
            var silverAccount = new SilverAccount();
            var goldAccount= new GoldAccount();

            classicAccount.SetSuccessor(silverAccount);
            silverAccount.SetSuccessor(goldAccount);
            //switch(account.Status)
            //{
            //}
            //throw new NotImplementedException();
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
