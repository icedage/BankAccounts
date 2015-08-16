using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TiresiasAPI.Models;

namespace BankAccounts.Services.Services
{
    public class CreditReportService : ICreditReportService
    {
        public async Task<CustomerDto> GetCreditReport(CustomerDto customer)
        {
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("FirstName", customer.FirstName.ToString()));
            postData.Add(new KeyValuePair<string, string>("LastName", customer.LastName));
            postData.Add(new KeyValuePair<string, string>("DoB", customer.DoB.ToString()));
            
            var formUrlEncodedContent = new FormUrlEncodedContent(postData); 

            var client = new HttpClient();
            
            var response = await client.PostAsync(ConfigurationManager.AppSettings["TiresiasAPI"], formUrlEncodedContent);

            var customerReport = await JsonConvert.DeserializeObjectAsync<CreditReportDto>(await response.Content.ReadAsStringAsync());

            customer.CreditReport = new CreditReportDto() { Score = customerReport.Score, IsEligible = customerReport.Lenders.Any(x => x.Status == Status.Unsatisfied) ? false : true };
            
            return customer;
        }
    }
}
