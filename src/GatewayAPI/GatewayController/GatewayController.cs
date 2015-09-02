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
            //_wrapper.SetComponent(_restSharpComponent);

        
            //_wrapper = new HttpRequestWrapper(ConfigurationManager.AppSettings["CustomersAPI"], Method.POST);
            //_wrapper.SetComponent(_restSharpComponent);
            var t = JsonConvert.SerializeObject(customer);
            _wrapper.Post(t);

            var account = _wrapper.Execute<Account>();
            return account;
        }

        public IList<Customer> Customers()
        {
            //_restSharpComponent.TokenizeRequest(new User());
            //_wrapper = new HttpRequestWrapper();

            //_wrapper = new HttpRequestWrapper();

            //_wrapper.SetComponent(_restSharpComponent);
            //var customers = _wrapper.Execute<List<Customer>>();
            //return customers;
            return null;
        }
    }
}
