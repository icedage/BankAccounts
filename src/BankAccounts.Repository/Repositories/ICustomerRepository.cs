using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();

        Customer Get(int customerId);

        int Add(Customer customer);

        bool Remove(string id);

        bool Update(Customer customer);
    }
}
