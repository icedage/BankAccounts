using AccountsAPI.Services.Services;
using AccountsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccountsAPI.Repository.Entities;
using System.Threading.Tasks;

namespace AccountsAPI.Controllers
{
    public class AccountsController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
           _accountService = accountService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(CreateAccountRequest request)
        {
            var customer = new CustomerDto()
            {
                CustomerId = request.CustomerId,
                AnnualNetSalary = request.FinancialDetails.AnnualNetSalary,
                AnnualGrossSalary = request.FinancialDetails.AnnualGrossSalary,
                NationalInsuranceNumber = request.NationalInsuranceNumber
            };

            _accountService.CreateAccount(customer);

            return Ok();
        }
    }
}
