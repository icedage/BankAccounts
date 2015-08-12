using BankAccounts.Services.Services;
using BankAccountsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankAccountsAPI.Controllers
{
    public class AccountsController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        //public IHttpActionResult Post(CreateAccountRequest request)
        //{
        //    return Ok();
        //}
    }
}
