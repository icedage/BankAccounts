using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankAccountsAPI.Models.Requests
{
    public class CustomerDetails
    {
        [Required]
        public string DrivingLicense { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public decimal AnnualGrossSalary { get; set; }
    }
}