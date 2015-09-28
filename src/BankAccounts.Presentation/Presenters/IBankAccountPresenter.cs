using AccountsAPI.Presentation.Models;

namespace AccountsAPI.Presentation.Presenters
{
    public interface IBankAccountPresenter
    {
        AccountDetailsModel ApplyForAccount(BankAccountModel account);
    }
}
