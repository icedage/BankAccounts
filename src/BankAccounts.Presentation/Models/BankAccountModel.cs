using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccounts.Presentation.Models
{
    public class BankAccountModel
    {
        public string PersonalId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nationality { get; set; }

        public string PostCode { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public decimal AnnualNetSalary { get; set; }

        public AddressModel Address { get; set; }
    }
}