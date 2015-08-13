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

                var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("login", "abc")
                };

                var content = new FormUrlEncodedContent(pairs);

                var client = new HttpClient {BaseAddress = new Uri("http://localhost:6740")};

                // call sync
                var response = await client.PostAsync("/api/membership/exist", content);

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
