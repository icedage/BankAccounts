using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAccounts.Repository.Entities;

namespace BankAccountsAPI.Controllers
{
    public class CustomersController : ApiController
    {
        [HttpPost]
        public IAsyncResult Post(CustomerDto customer)
        {
            return Ok();
        }
    }
}
