using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T Get(string id);

        void Add(T item);

        bool Remove(string id);

        bool Update(T item);
    }
}
