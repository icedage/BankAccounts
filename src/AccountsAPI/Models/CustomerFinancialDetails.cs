using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountsAPI.Models
{
    public class CustomerFinancialDetails
    {
        public decimal Score { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public decimal AnnualNetSalary { get; set; }
    }
}