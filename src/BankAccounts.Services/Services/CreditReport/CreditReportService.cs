using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TiresiasAPI.Models;

namespace AccountsAPI.Services.Services
{
    public class CreditReportService : ICreditReportService
    {
        public async Task<CustomerDto> GetCreditReport(CustomerDto customer)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(new
            {
                NationalInsuranceNumber = customer.NationalInsuranceNumber
            }), System.Text.Encoding.UTF8, "application/json");

            var client = new HttpClient() { BaseAddress = new Uri("http://localhost:25720/") };

            var response = client.PostAsync("api/CreditScore", stringContent).Result;

            var customerReport = JsonConvert.DeserializeObject<CreditReportDto>(response.Content.ReadAsStringAsync().Result);

            customer.CreditReport = new CreditReportDto() { Score = customerReport.Score, IsEligible = customerReport.Lenders.Any(x => x.Status == Status.Unsatisfied) ? false : true };

            return customer;
        }
    }
}
