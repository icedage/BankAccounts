﻿using BankAccounts.Repository.Entities;
using BankAccounts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Services
{
    public interface ICreditReportService
    {
        Task<CustomerDto> GetCreditReport(CustomerDto customer);
    }
}