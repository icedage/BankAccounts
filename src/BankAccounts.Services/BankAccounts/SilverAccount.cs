using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.AccountBenefits;

namespace BankAccounts.Services.BankAccounts
{
    public class SilverAccount: BankAccountLevelApprover
    {
        public SilverAccountBenefits SilverAccountBenefits{get;set;}

        public override BankAccountApproval ProcessRequest(CustomerDto bankAccountApproval)
        {
            throw new NotImplementedException();
        }
    }
}
