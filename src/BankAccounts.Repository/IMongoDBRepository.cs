using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository
{
    public interface IMongoDBRepository<T> where T :class
    {
        IEnumerable<T> GetAll();

        T Get(string id);

        void Add(T item);

        void Remove(string id);

        void Update(T item);
    }
}
