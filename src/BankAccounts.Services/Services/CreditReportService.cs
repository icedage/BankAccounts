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

namespace BankAccounts.Services.Services
{
    public class CreditReportService : ICreditReportService
    {

        public async Task<CreditReportDto> GetCreditReport(CustomerDto customer)
        {
           CreditReportDto result;

            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("Name", "test"));
            postData.Add(new KeyValuePair<string, string>("Price ", "100"));

            var formUrlEncodedContent = new FormUrlEncodedContent(postData); 

            var client = new HttpClient();
            var response = await client.PostAsync(ConfigurationManager.AppSettings["TiresiasAPI"], formUrlEncodedContent);
            
            using (HttpContent content = response.Content)
            {
                result = await JsonConvert.DeserializeObjectAsync<CreditReportDto>(await content.ReadAsStringAsync());
            }
            return result;
        }

        CreditReportDto ICreditReportService.GetCreditReport(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
