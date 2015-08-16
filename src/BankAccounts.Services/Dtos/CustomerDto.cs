using BankAccounts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.Entities
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersonalId { get; set; }

        public string Nationality { get; set; }

        public IList<AddressDto> Addresses { get; set; }

        public DateTime DoB { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public decimal AnnualNetSalary { get; set; }

        public CreditReportDto CreditReport { get; set; }
    }
}
