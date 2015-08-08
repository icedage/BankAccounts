using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiresiasAPI.Models
{
    public class CreditReportRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DoF { get; set; }

        public IList<Address> PostCode { get; set; }

        public decimal Score { get; set; }

        public IList<Default> Defaults { get; set; }
    }
}