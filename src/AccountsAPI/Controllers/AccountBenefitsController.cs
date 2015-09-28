using AccountsAPI.Services.Services;
using AccountsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Contracts;
using AccountsAPI.Services.BankAccounts;
using AccountsAPI.Repository.Repositories;

namespace AccountsAPI.Controllers
{
    public class AccountBenefitsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(BankAccountBenefits request)
        {
            var account = ChainOfAccountsInitializer();
            account.ProcessRequest(request);
            return Ok();
        }

        private IRequestAccountHandler ChainOfAccountsInitializer()
        {
            var account = new ClassicAccount(new ClassicAccountBenefitsRepository());
            var silverAccount = new SilverAccount(new SilverAccountBenefitsRepository());
            var goldAccount = new GoldAccount(new GoldAccountBenefitsRepository());
            account.Successor = silverAccount;
            silverAccount.Successor = goldAccount;
            return account;
        }
    }
}
