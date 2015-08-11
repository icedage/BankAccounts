using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Services.BankAccounts
{
    public abstract class BankAccountStatusApprover: IBankAccountLevelApprover
    {
        protected BankAccountStatusApprover _successor;

        public virtual void SetSuccessor(BankAccountStatusApprover successor)
        {
            this._successor = successor;
        }

        public abstract BankAccountBenefits ProcessRequest(CustomerDto customer);
    }
}
