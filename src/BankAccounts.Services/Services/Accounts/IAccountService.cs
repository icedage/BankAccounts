using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.Services
{
    public interface IAccountService
    {
        AccountDto CreateAccount(CustomerDto customer);
    }
}
