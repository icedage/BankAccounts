using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Dtos
{
    public class Overdraft
    {
        public decimal OverDraftBalance { get; set; }

        public decimal PerdayCharges { get; set; }

        public bool IncludesOverdraftBuffer { get; set; }

        public bool IncludesGracePeriod {get;set;}

    }
}
