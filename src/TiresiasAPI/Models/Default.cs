using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiresiasAPI.Models
{
    public class Default
    {
        public Status Status { get; set; }

        public DateTime Datatime { get; set; }

        public string Lender { get; set; }

        public decimal Balance { get; set; }

        public decimal PaidAmount { get; set; }

        public IList<string> Products { get; set; }
    }
}