using BankAccounts.Services.Services;
using BankAccountsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAccounts.Repository.Entities;
using BankAccounts.Contracts;
using BankAccounts.Services.BankAccounts;

namespace BankAccountsAPI.Controllers
{
    public class AccountsController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public IHttpActionResult Post(BankAccountBenefits request)
        {
            
            return Ok();
        }

        private IRequestAccountHandler ChainOfAccountsInitializer()
        {
            IRequestAccountHandler account = new GoldAccount();
            var silverAccount = new SilverAccount(null) { Successor = account };
            var classicAccount = new ClassicAccount() { Successor = silverAccount };
            return account;
        }
    }
}
