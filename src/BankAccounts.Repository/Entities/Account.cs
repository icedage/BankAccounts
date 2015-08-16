using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Contracts;

namespace BankAccounts.Repository.Entities
{
    public class Account
    {
        public int CustomerId { get; set; }

        public BankAccountStatus Status { get; set; }

        public int SortCode { get; set; }

        public int AccountNumber { get; set; }

        public BankAccountBenefits BankAccountBenefits { get; set; }
    }
}
