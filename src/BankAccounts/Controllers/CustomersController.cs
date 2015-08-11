using BankAccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.Services;
using System.Threading.Tasks;

namespace BankAccountsAPI.Controllers
{
    public class CustomersController : ApiController
    {
        private ICreditReportService _creditReportService;
        private ICustomerService _customerService;

        public CustomersController(ICreditReportService creditReportService, ICustomerService customerService)
        {
            _creditReportService = creditReportService;
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(CustomerDetails customerDetails)
        {
            try
            {
                var customerDto = new CustomerDto() { 
                                                        FirstName = customerDetails.FirstName,
                                                        LastName = customerDetails.LastName,
                                                        DoB = customerDetails.BirthDate,
                                                        Nationality = customerDetails.Nationality,
                                                        AnnualGrossSalary = customerDetails.AnnualGrossSalary,
                                                        AnnualNetSalary = customerDetails.AnnualNetSalary,
                                                        PersonalId = customerDetails.PersonalId
                                                    };

                var report = await _creditReportService.GetCreditReport(customerDto);

                var customer = _customerService.CreateCustomer(customerDto);

                return Ok();
            }
            catch (Exception ex)
            {
                //Log exception
                return BadRequest("Server error");
            }
            
        }
    }
}
