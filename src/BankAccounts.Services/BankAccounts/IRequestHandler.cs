using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.BankAccounts
{
    public interface IRequestAccountHandler
    {
        BankAccountBenefits Benefits { get; set; }

        void ProcessRequest(CustomerDto customer);

        IRequestAccountHandler Successor { get; set; }
    }
}
