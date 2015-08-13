using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountsAPI.Models
{
    public class CreateAccountRequest
    {
        public int CustomerId { get; set; }

        public CustomerFinancialDetails FinancialDetails { get; set; }
    }
}