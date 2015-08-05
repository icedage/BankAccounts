using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiresiasAPI.Models
{
    public class CreditReportRequest
    {
        public decimal Score { get; set; }

        public IList<Default> Defaults { get; set; }
    }
}