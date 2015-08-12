using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;

namespace BankAccounts.Services.BankAccounts
{
    public class ClassicAccount : IRequestAccountHandler
    {
        public BankAccountBenefits Benefits { get; set; }


        public void ProcessRequest(CustomerDto customer)
        {
            if( customer.AnnualGrossSalary > 5000 || customer.AnnualGrossSalary < 30000 )
            {
                Benefits.ClassicAccountBenefits.IncludesCheckBook = true;
                Benefits.ClassicAccountBenefits.IncludesInternetBanking = true;
                Benefits.ClassicAccountBenefits.Overdraft = new Overdraft() {  IncludesGracePeriod = false,
                                                                                           IncludesOverdraftBuffer = false,
                                                                                           OverDraftBalance = 35,
                                                                                           PerdayCharges = 1.5m
                                                                                        };
            }
            else
            {
                Successor.ProcessRequest(customer);
            }
        }

        public IRequestAccountHandler Successor { get; set; }
    }
}
