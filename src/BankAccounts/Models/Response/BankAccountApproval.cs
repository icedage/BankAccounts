using BankAccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountsAPI.Models.Response
{
    public class BankAccountApproval
    {
        public CustomerDetails CustomerDetails { get; set; }

        public string SortCode { get; set; }

        public string AccountNumber { get; set; }

        public Guid CustomerId { get; set; }
    }
}