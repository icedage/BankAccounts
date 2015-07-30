using BankAccounts.Repository.Entities;
using BankAccounts.Services.Services;
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
        private readonly  IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Post(CustomerDetails customerDetails)
        {
            try
            {
                _bankAccountService.CreateBankAccount(new BankAccountDto()
                {
                    Address = customerDetails.Address,
                    BirthDate = customerDetails.BirthDate,
                    FirstName = customerDetails.FirstName,
                    LastName = customerDetails.LastName,
                    PostCode = customerDetails.PostCode

                });

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message); 
            }
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var bankAccounts = _bankAccountService.GetBankAccounts();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message); 
            }
        }

        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            try 
            {
                var account = _bankAccountService.GetBankAccount(id);
                return Ok(account);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Put(CustomerDetails customerDetails)
        {
            try
            {
                _bankAccountService.UpdateBankAccount(new BankAccountDto()
                {
                    Address = customerDetails.Address,
                    BirthDate = customerDetails.BirthDate,
                    FirstName = customerDetails.FirstName,
                    LastName = customerDetails.LastName,
                    PostCode = customerDetails.PostCode
                });

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(Guid id)
        {
            try
            {
                _bankAccountService.DeleteBankAccount(id);
              
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
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
