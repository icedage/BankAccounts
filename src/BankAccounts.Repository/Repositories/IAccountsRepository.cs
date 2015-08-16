using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository.Repositories
{
    public interface IAccountsRepository
    {
        void CreateAccount(Account account);
    }
}
