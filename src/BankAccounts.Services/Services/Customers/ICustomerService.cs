using BankAccounts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public interface ICustomerService
    {
        int CreateCustomer(CustomerDto customer);

        bool Update(CustomerDto customer);

        IEnumerable<CustomerDto> GetAll();

        CustomerDto GetById(int id);
    }
}
