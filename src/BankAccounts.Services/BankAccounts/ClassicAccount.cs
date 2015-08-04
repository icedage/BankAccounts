using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.BankAccounts
{
    public class ClassicAccount : BankAccountStatusApprover
    {
        private BankAccountBenefits _bankAccountApproval;

        public ClassicAccount()
        {
            _bankAccountApproval = new BankAccountBenefits();
        }

        public override BankAccountBenefits ProcessRequest(CustomerDto bankAccountApproval)
        {
            if( bankAccountApproval.AnnualGrossSalary > 5000 || bankAccountApproval.AnnualGrossSalary < 30000 )
            {
                _bankAccountApproval.ClassicAccountBenefits.IncludesCheckBook = true;
                _bankAccountApproval.ClassicAccountBenefits.IncludesInternetBanking = true;
                _bankAccountApproval.ClassicAccountBenefits.Overdraft = new Overdraft() {  IncludesGracePeriod = false,
                                                                                           IncludesOverdraftBuffer = false,
                                                                                           OverDraftBalance = 35,
                                                                                           PerdayCharges = 1.5m
                                                                                        };
            }
            else
            {
                _bankAccountApproval = this._successor.ProcessRequest(bankAccountApproval);
            }
            return _bankAccountApproval;
        }
    }
}
