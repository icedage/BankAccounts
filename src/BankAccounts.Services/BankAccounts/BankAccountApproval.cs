using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Services.AccountBenefits;
using BankAccounts.Services.AccountBenefits.Classic;
using BankAccounts.Services.AccountBenefits.Gold;

namespace BankAccounts.Services.BankAccounts
{
    public class BankAccountBenefits
    {
        public BankAccountBenefits()
        {
            ClassicAccountBenefits = new ClassicAccountBenefits();
            SilverAccountBenefits = new SilverAccountBenefits();
            GoldAccountBenefits = new GoldAccountBenefits();
        }

        public BankAccountStatus Status { get; set; }

        public ClassicAccountBenefits ClassicAccountBenefits { get; set; }

        public SilverAccountBenefits SilverAccountBenefits { get; set; }

        public GoldAccountBenefits GoldAccountBenefits { get; set; }
    }
}
