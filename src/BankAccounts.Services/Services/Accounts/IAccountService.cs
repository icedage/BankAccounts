using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.Dtos;

namespace AccountsAPI.Services.Services
{
    public interface IAccountService
    {
        Task<AccountDto> CreateAccount(CustomerDto customer);
    }
}
