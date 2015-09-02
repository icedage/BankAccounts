using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Services.Services
{
    public interface ICreditReportService
    {
        Task<CustomerDto> GetCreditReport(CustomerDto customer);
    }
}
