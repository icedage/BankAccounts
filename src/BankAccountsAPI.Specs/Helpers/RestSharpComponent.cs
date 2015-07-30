using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAPI.Specs.Helpers
{
    public abstract class RestSharpComponent
    {
        public IRestRequest Request  { get; set; }

        public IRestClient Client { get; set; }
    }
}
