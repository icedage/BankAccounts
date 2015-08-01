using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.BankAccounts
{
    public class BankAccountApproval
    {
        BankAccountLevel Level { get; set; }

        ClassicAccount ClassicAccount { get; set; }

        SilverAccount SilverAccount { get; set; }

        GoldAccount GoldAccount { get; set; }
    }
}
