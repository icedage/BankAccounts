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

        public IList<Address> Addresses { get; set; }
    }
}