using AccountsAPI.Contracts;

namespace AccountsAPI.Models
{
    public class AccountModel
    {
        public string AccountNo { get; set; }

        public string SortCode { get; set; }

        public BankAccountBenefits Status { get; set; }
    }
}