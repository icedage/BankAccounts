using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("BankAccounts")
        { }

        public DbSet<Customer> Customers { get; set; }
    }
}
