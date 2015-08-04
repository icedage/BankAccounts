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
        private ICreditReportService _creditReportService;

        public CustomerService(ICreditReportService creditReportService)
        {
            _creditReportService = creditReportService;
        }

        public void CreateCustomer(CustomerDto customer)
        {
            var report = _creditReportService.GetCreditReport(customer);
 
            throw new NotImplementedException();
        }
    }
}
