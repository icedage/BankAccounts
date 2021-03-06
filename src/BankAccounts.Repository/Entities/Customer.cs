﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Repository.Entities
{
    public class Customer
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal AnnualGrossSalary { get; set; }

        public string Nationality { get; set; }

    }
}
