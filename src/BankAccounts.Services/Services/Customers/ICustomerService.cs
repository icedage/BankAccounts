using AccountsAPI.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Services
{
    public interface ICustomerService
    {
        int CreateCustomer(CustomerDto customer);
    }
}
