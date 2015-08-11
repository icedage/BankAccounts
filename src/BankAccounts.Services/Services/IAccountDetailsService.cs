using BankAccounts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public interface IAccountDetailsService
    {
        AccountDto GetAccount();
    }
}
