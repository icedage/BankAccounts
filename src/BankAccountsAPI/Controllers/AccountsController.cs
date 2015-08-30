using BankAccounts.Services.Services;
using BankAccountsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAccounts.Repository.Entities;

namespace BankAccountsAPI.Controllers
{
    public class AccountBenefitsController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountBenefitsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IHttpActionResult Post(CreateAccountRequest request)
        {
            var customer = new CustomerDto() {  CustomerId=request.CustomerId ,
                                                AnnualNetSalary= request.FinancialDetails.AnnualNetIncome
                                             };

            _accountService.CreateAccount(customer);

            return Ok();
        }
    }
}
