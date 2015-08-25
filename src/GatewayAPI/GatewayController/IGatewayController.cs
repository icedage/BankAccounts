using GatewayAPI.Entities;
using System.Collections.Generic;

namespace GatewayAPI.GatewayController
{
    public interface IGatewayController
    {
        IList<Customer> Customers();

        int CreateCustomer(Customer customer);
    }
}
