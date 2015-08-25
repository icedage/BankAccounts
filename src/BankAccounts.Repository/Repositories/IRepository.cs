using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T Get(int customerId);

        int Add(T customer);

        bool Remove(string id);

        bool Update(T customer);
    }
}
