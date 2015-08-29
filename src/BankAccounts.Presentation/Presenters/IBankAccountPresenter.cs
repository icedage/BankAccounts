using BankAccounts.Presentation.Models;

namespace BankAccounts.Presentation.Presenters
{
    public interface IBankAccountPresenter
    {
        AccountDetailsModel ApplyForAccount(BankAccountModel account);
    }
}
