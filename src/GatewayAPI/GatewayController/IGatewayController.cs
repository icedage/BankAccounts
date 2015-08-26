using GatewayAPI.Entities;
using System.Collections.Generic;

namespace GatewayAPI.GatewayController
{
    public interface IGatewayController
    {
        IList<Customer> Customers();

        Account CreateCustomer(Customer customer);
    }
}
