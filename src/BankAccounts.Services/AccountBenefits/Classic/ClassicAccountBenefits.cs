﻿using BankAccounts.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Services.AccountBenefits.Classic
{
    public class ClassicAccountBenefits
    {
        public bool IncludesInternetBanking {get;set;}

        public bool IncludesCheckBook { get; set; }

        public Overdraft Overdraft { get; set; }
    }
}
