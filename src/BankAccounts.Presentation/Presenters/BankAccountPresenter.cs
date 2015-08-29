using BankAccounts.Presentation.Models;
using GatewayAPI.Entities;
using GatewayAPI.GatewayController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccounts.Presentation.Presenters
{
    public class BankAccountPresenter : IBankAccountPresenter
    {
        private IGatewayController _gatewayController;

        public BankAccountPresenter(IGatewayController gatewayController)
        {
            _gatewayController = gatewayController;
        }

        public AccountDetailsModel ApplyForAccount(BankAccountModel account)
        {
            var accountDetails= _gatewayController.CreateCustomer(new Customer() {  AnnualGrossSalary= account.AnnualGrossSalary,
                                                                                    AnnualNetSalary = account.AnnualNetSalary,
                                                                                    BirthDate = account.BirthDate,
                                                                                    FirstName= account.FirstName,
                                                                                    LastName = account.LastName,
                                                                                    Nationality=account.Nationality,
                                                                                    PersonalId= account.PersonalId,
                                                                                    PostCode= account.PostCode
                                                                                });
            return new AccountDetailsModel()
            {
                AccountNo = accountDetails.AccountNo,
                SortCode = accountDetails.SortCode
            };
        }
    }
}