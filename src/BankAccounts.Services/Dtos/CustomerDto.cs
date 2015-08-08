using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.Entities
{
    public class CustomerDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersonalId { get; set; }

        public string Nationality { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public DateTime DoB { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public decimal AnnualNetSalary { get; set; }
    }
}
