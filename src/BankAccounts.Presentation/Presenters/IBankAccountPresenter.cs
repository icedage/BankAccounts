using BankAccounts.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Presentation.Presenters
{
    public interface IBankAccountPresenter
    {
        AccountDetailsModel ApplyForAccount(BankAccountModel account);
    }
}
