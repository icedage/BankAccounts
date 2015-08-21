using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI
{
    public class RestSharpComponent
    {
        public IRestRequest Request { get; set; }

        public IRestClient Client { get; set; }

        public RestSharpComponent()
        {
            Client = new RestClient("http://localhost/BankAccountsAPI/");
            Request = new RestRequest("oauth/token", Method.POST);
        }
    }
}
