using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountsAPI.Models
{
    public class Address
    {
        public string PostCode { get; set; }

        public string FirstLine { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public DateTime DateMovedTo { get; set; }

        public DateTime DateMovedFrom { get; set; }
    }
}