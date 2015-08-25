using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatewayAPI.Entities;

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

        public int CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> Customers()
        {
            _restSharpComponent.TokenizeRequest(new User());

            _wrapper = new HttpRequestWrapper("",RestSharp.Method.POST);

            _wrapper.SetComponent(_restSharpComponent);

            var customers = _wrapper.Execute<List<Customer>>();

            return customers;
        }
    }
}
