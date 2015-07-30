using BankAccounts.Repository.DataAccessComponents;
using BankAccounts.Repository.Entities;
using BankAccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BankAccountsAPI.Controllers
{
    public class BankAccountController : ApiController
    {
        private readonly  IBankAccountRepository _bankAccountRepository;

        public BankAccountController()
        {
            _bankAccountRepository = new BankAccountRepository();
        }

        [Authorize]
        public async Task<IHttpActionResult> Post(CustomerDetails customerDetails)
        {
            var errorResult = GetErrorResult(customerDetails);

            if (errorResult != null)
            {
                return errorResult;
            }

           var result= _bankAccountRepository.CreateAccount(new CustomerDetailsDto() {
                                                                                Address=customerDetails.Address,
                                                                                BirthDate=customerDetails.BirthDate,
                                                                                FirstName=customerDetails.FirstName,
                                                                                LastName=customerDetails.LastName,
                                                                                PostCode=customerDetails.PostCode,
                                                                                //Salary=customerDetails.Salary
                                                                          });
           if (result != null)
           {
               return Ok();
           }

           return BadRequest();
        }

        [Authorize]
        public async Task<IHttpActionResult> GetAll()
        {
            var accounts = _bankAccountRepository.GetAccounts();
            return Ok(accounts);
        }

        //public async Task<IHttpActionResult> Get(Guid id)
        //{
        //    var account = _bankAccountRepository.GetAccount(id);
        //    return Ok(account);
        //}

        public async Task<IHttpActionResult> Put(CustomerDetails customerDetails)
        {
            return Ok();
        }

        public async Task<IHttpActionResult> Delete(Guid id)
        {
            return Ok();
        }

        private IHttpActionResult GetErrorResult(CustomerDetails customerDetails)
        {
            if (customerDetails == null)
            {
                return InternalServerError();
            }

            if (ModelState.IsValid)
            {
                // No ModelState errors are available to send, so just return an empty BadRequest.
                return BadRequest();
            }

            return null;
        }
    }
}
