using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository.Entities;

namespace AccountsAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        int Add(T customer);
    }
}
