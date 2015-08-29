using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatewayAPI.Entities;
using RestSharp;
using System.Configuration;

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
            _restSharpComponent.TokenizeRequest(new User() { Username = "SuperUser", Password = "P@ssword123", grant_type="password" });
            _wrapper = new HttpRequestWrapper(ConfigurationManager.AppSettings["CustomersAPI"], Method.POST);
            _wrapper.SetComponent(_restSharpComponent);
            _wrapper.AddBody(customer);
            var account = _wrapper.Execute<Account>();
            return account;
        }

        public IList<Customer> Customers()
        {
            _restSharpComponent.TokenizeRequest(new User());
            _wrapper = new HttpRequestWrapper(ConfigurationManager.AppSettings["CustomersAPI"], RestSharp.Method.POST);
            _wrapper.SetComponent(_restSharpComponent);
            var customers = _wrapper.Execute<List<Customer>>();
            return customers;
        }
    }
}
