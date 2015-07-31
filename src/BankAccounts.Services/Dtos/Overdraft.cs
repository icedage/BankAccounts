﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.Dtos
{
    public class Overdraft
    {
        public bool HasOverDraft { get; set; }

        public decimal OverDraftBalance { get; set; }

        public decimal PerdayCharges { get; set; }

    }
}
