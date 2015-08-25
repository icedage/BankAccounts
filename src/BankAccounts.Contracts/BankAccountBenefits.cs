﻿using BankAccounts.Services.AccountBenefits;
using BankAccounts.Services.AccountBenefits.Classic;
using BankAccounts.Services.AccountBenefits.Gold;

namespace BankAccounts.Contracts
{
    public class BankAccountBenefits
    {
        public BankAccountStatus Status { get; set; }

        public ClassicAccountBenefits ClassicAccountBenefits { get; set; }

        public SilverAccountBenefits SilverAccountBenefits { get; set; }

        public GoldAccountBenefits GoldAccountBenefits { get; set; }
    }
}
