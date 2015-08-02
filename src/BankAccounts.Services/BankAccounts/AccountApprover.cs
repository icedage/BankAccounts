using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.BankAccounts
{
    public abstract class BankAccountLevelApprover: IBankAccountLevelApprover
    {
        protected BankAccountLevelApprover successor;

        public void SetSuccessor(BankAccountLevelApprover successor)
        {
            this.successor = successor;
        }

        public abstract BankAccountApproval ProcessRequest(CustomerDto bankAccountApproval);
    }
}
