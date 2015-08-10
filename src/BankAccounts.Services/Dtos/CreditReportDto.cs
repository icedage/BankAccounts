using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiresiasAPI.Models;

namespace BankAccounts.Services.Dtos
{
    public class CreditReportDto
    {
        public decimal Score { get; set; }

        public bool IsEligible { get; set; }

        public IList<DefaultDto> Lenders { get; set; }
    }
}
