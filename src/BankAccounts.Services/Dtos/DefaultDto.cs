using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiresiasAPI.Models
{
    public class DefaultDto
    {
        public Status Status { get; set; }

        public DateTime Datetime { get; set; }

        public string Lender { get; set; }

        public decimal Balance { get; set; }

        public decimal PaidAmount { get; set; }

        public IList<string> Products { get; set; }
    }
}