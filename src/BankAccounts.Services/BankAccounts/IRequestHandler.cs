using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Contracts;
using AccountsAPI.Repository.Entities;

namespace AccountsAPI.Services.BankAccounts
{
    public interface IRequestAccountHandler
    {
        void ProcessRequest(BankAccountBenefits accountBenefits);

        IRequestAccountHandler Successor { get; set; }
    }
}
