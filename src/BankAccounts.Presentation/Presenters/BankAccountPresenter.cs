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
            _gatewayController.CreateCustomer(new Customer() { });
            throw new NotImplementedException();
        }
    }
}