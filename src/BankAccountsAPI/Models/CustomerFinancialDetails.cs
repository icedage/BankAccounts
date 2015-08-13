using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountsAPI.Models
{
    public class CustomerFinancialDetails
    {
        public decimal Score { get; set; }

        public decimal AnnualNetIncome { get; set; }
    }
}