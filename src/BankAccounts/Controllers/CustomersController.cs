using BankAccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Services;

namespace BankAccountsAPI.Controllers
{
    public class CustomersController : ApiController
    {
        private ICreditReportService _creditReportService;

        public CustomersController(ICreditReportService creditReportService)
        {
            _creditReportService = creditReportService;
        }

        [HttpPost]
        public IHttpActionResult Post(CustomerDetails customerDetails)
        {
            return Ok();
        }
    }
}
