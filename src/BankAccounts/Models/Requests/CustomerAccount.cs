using AccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountsAPI.Models
{
    public class CustomerAccount
    {
        public CustomerDetails Customer { get; set; }

        public IList<AccountModel> Accounts { get; set; }
    }
}