using AccountsAPI.Services.AccountBenefits;
using AccountsAPI.Services.AccountBenefits.Classic;
using AccountsAPI.Services.AccountBenefits.Gold;

namespace AccountsAPI.Contracts
{
    public class BankAccountBenefits
    {
        public BankAccountStatus Status { get; set; }

        public ClassicAccountBenefits ClassicAccountBenefits { get; set; }

        public SilverAccountBenefits SilverAccountBenefits { get; set; }

        public GoldAccountBenefits GoldAccountBenefits { get; set; }
    }
}
