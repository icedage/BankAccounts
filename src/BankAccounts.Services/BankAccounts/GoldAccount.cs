using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.BankAccounts
{
    public class GoldAccount : BankAccountLevelApprover
    {
        public override BankAccountApproval ProcessRequest(CustomerDto bankAccountApproval)
        {
            throw new NotImplementedException();
        }
    }
}
