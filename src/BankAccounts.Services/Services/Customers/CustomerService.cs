using AccountsAPI.Repository;
using AccountsAPI.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Services
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int CreateCustomer(CustomerDto customerDto)
        {
            var customer = new Customer()
            {
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                BirthDate = customerDto.DoB,
                AnnualGrossSalary = customerDto.AnnualGrossSalary,
                Id= customerDto.PersonalId,
                Nationality= customerDto.Nationality
                
            };
            var customerId = _customerRepository.Add(customer);

            return customerId;
        }
    }
}
