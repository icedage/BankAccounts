using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public class CreditReportService : ICreditReportService
    {

        public async Task<CreditReportDto> GetCreditReport(CustomerDto customer)
        {
            string page = "http://en.wikipedia.org/";
            string result = string.Empty;

            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                result = await content.ReadAsStringAsync();


            }
            return result;
        }
    }
}
