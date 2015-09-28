using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountsAPI.Models.Requests
{
    public class CustomerDetails// : IValidatableObject
    {
       public string PersonalId { get; set; }

       public string FirstName { get; set; }

       public string LastName { get; set; }

       public string Nationality { get; set; }

       public Address Address { get; set; }

       public string PostCode { get; set; }

       public DateTime BirthDate { get; set; }

       public decimal AnnualGrossSalary { get; set; }

       public decimal AnnualNetSalary { get; set; }

       public string NationalInsuranceNumber { get; set; }

       public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
       {
           if (string.IsNullOrEmpty(this.FirstName))
               yield return new ValidationResult("FirstName is required");
           if (string.IsNullOrEmpty(this.LastName))
               yield return new ValidationResult("LastName is required");
           if (string.IsNullOrEmpty(this.Nationality))
               yield return new ValidationResult("Nationality is required");
           if (string.IsNullOrEmpty(this.Address.PostCode))
               yield return new ValidationResult("PostCode is required");
           if (this.BirthDate==DateTime.MinValue)
               yield return new ValidationResult("BirthDate is required");
           if (AnnualGrossSalary==0)
               yield return new ValidationResult("AnnualGrossSalary is required");
           if (this.AnnualNetSalary==0)
               yield return new ValidationResult("AnnualNetSalary is required");
        }
    }
}