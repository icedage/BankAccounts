using BankAccounts.Repository;
using BankAccounts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int CreateCustomer(CustomerDto customerDto)
        {
            var customer = new Customer()
            {
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                DoB = customerDto.DoB,
                AnnualGrossSalary = customerDto.AnnualGrossSalary
            };
            var customerId = _customerRepository.Add(customer);

            return customerId;
        }
    }
}
