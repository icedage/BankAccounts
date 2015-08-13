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
                DoB = customerDto.DoB,
                AnnualGrossSalary = customerDto.AnnualGrossSalary
            };
            var customerId = _customerRepository.Add(customer);

            return customerId;
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            var customers = _customerRepository.GetAll();

            var  customerCollection = new List<CustomerDto>();

            customers.ForEach((x) => customerCollection.Add(new CustomerDto()));
            
            return customerCollection;
        }

        public bool Update(CustomerDto customer)
        {
            return _customerRepository.Update(new Customer() { });
        }

        public CustomerDto GetById(int id)
        {
            var customer = _customerRepository.Get(id);

            return new CustomerDto() { };
        }
    }
}
