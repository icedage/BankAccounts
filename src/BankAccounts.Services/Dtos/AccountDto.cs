using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Dtos
{
    public class AccountDto
    {
        public int SortCode { get; set; }

        public int AccountNumber { get; set; }

        public int AccountId { get; set; }

        public int CustomerId { get; set; }
    }
}
