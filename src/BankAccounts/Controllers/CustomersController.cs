using AccountsAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.Services;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using AccountsAPI.Services.Dtos;

namespace AccountsAPI.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IHttpActionResult> Post(CustomerDetails customerDetails)
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

              

                var customerID = _customerService.CreateCustomer(customerDto);

                var details = new {
                                    AnnualGrossSalary = customerDetails.AnnualGrossSalary.ToString(),
                                    AnnualNetSalary = customerDetails.AnnualNetSalary.ToString()
                                  };

                var stringContent = new StringContent(JsonConvert.SerializeObject( new { CustomerId = customerID,
                                                                                         FinancialDetails = details,
                                                                                         NationalInsuranceNumber = customerDetails.NationalInsuranceNumber
                                                                                       }), System.Text.Encoding.UTF8, "application/json");
                
                var client = new HttpClient {BaseAddress = new Uri(ConfigurationManager.AppSettings["AccountsAPI"])};

                var response = await client.PostAsync("/api/accounts", stringContent);

                var customerReport = JsonConvert.DeserializeObject<AccountDto>(response.Content.ReadAsStringAsync().Result);

                return Ok();
        }
    }
}
