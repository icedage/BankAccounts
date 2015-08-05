using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(string id)
        {
            using(var context = new CustomerContext())
            {
                return context.Customers.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public void Add(Customer item)
        {
            using(var context = new CustomerContext())
            {
                context.Customers.Add(item);
                context.SaveChanges();
            }
        }

        public bool Update(Customer customer)
        {
            using(var context = new CustomerContext())
            {
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public bool Remove(string id)
        {
            using(var context = new CustomerContext())
            {
                var customer = context.Customers.Find(id);
                context.Customers.Remove(customer);
                return context.SaveChanges() > 0;
            }
        }
    }
}
