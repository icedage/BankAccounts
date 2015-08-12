using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Services.BankAccounts;

namespace BankAccounts.Services.Dtos
{
        public class CutomerAccountDto
        {
            public int CustomerId { get; set; }

            public AccountDto AccountCodes { get;set; }

            public BankAccountBenefits AccountBenefits { get; set; }
        }
}
