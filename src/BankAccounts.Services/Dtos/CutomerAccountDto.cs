using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Contracts;
using AccountsAPI.Services.BankAccounts;

namespace AccountsAPI.Services.Dtos
{
        public class CutomerAccountDto
        {
            public int CustomerId { get; set; }

            public AccountDto AccountCodes { get;set; }

            public BankAccountBenefits AccountBenefits { get; set; }
        }
}
