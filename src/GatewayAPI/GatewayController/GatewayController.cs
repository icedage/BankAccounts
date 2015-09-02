using System.Collections.Generic;
using GatewayAPI.Entities;
using RestSharp;
using System.Configuration;
using Newtonsoft.Json;

namespace GatewayAPI.GatewayController
{
    public class GatewayController : IGatewayController
    {
        private HttpRequestAuthenticator _restSharpComponent;
        private HttpRequestWrapper _wrapper;

        public GatewayController()
        {
            _restSharpComponent = new HttpRequestAuthenticator();
        }

        public Account CreateCustomer(Customer customer)
        {

            //username & password will be both retrieved by login process
            _restSharpComponent.TokenizeRequest(new User() { username="SuperUser",
                                                             password ="P@ssword123",
                                                             grant_type ="password"
                                                            });
            _wrapper = new HttpRequestWrapper(_restSharpComponent, "http://localhost:51313/api/customers", Method.POST);
            
            var serializedRequest = JsonConvert.SerializeObject(customer);

            _wrapper.Post(serializedRequest);

            var account = _wrapper.Execute<Account>();
            return account;
        }
    }
}
