using BankAccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankAccountsAPI.Controllers
{
    public class CustomersController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(CustomerDetails customerDetails)
        {

            return Ok();
        }
    }
}
