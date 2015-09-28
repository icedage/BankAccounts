using AccountsAPI.Presentation.Models;
using GatewayAPI.Entities;
using GatewayAPI.GatewayController;

namespace AccountsAPI.Presentation.Presenters
{
    public class BankAccountPresenter : IBankAccountPresenter
    {
        private IGatewayController _gatewayController;

        public BankAccountPresenter(IGatewayController gatewayController)
        {
            _gatewayController = gatewayController;
        }

        public AccountDetailsModel ApplyForAccount(BankAccountModel bankAccount)
        {

            var account = _gatewayController.CreateCustomer(new Customer() {
                                                               AnnualGrossSalary = bankAccount.AnnualGrossSalary,
                                                               AnnualNetSalary = bankAccount.AnnualNetSalary,
                                                               BirthDate = bankAccount.BirthDate,
                                                               FirstName = bankAccount.FirstName,
                                                               LastName = bankAccount.LastName,
                                                               Nationality = bankAccount.Nationality,
                                                               PersonalId = bankAccount.PersonalId,
                                                               PostCode = bankAccount.PostCode
                                                             });
            return new AccountDetailsModel()
            {
                AccountNo = account.AccountNo,
                SortCode = account.SortCode
            };
        }
    }
}