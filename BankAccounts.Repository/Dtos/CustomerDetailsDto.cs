﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.Entities
{
    public class CustomerDetailsDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }
    }
}