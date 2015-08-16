using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.Services
{
    public interface IAccountService
    {
        void CreateAccount(CustomerDto customer);
    }
}
