using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository.Entities;
using BankAccounts.Services.AccountBenefits;
using BankAccounts.Services.AccountBenefits.Classic;
using BankAccounts.Services.AccountBenefits.Gold;

namespace BankAccounts.Repository.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public AccountsRepository()
        {
            _sqlConnection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
        }

        public void CreateAccount(Account customer)
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand();
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@FirstName", customer.CustomerId));
                _sqlCommand.Parameters.Add(new SqlParameter("@LastName", customer.AccountNumber));
                _sqlCommand.Parameters.Add(new SqlParameter("@PersonalId", customer.SortCode));

                var accountId = 0;

                //switch(customer.Status)
                //{
                //    case AccountStatus.Classic:
                //    {
                //        CreateClassicAccountBenefits(accountId);
                //        break;
                //    }
                //    case AccountStatus.Silver:
                //    {
                //        CreateSilverAccountBenefits(accountId);
                //        break;
                //    }
                //    case AccountStatus.Gold:
                //    {
                //        CreateGoldAccountBenefits(accountId);
                //        break;
                //    }

                //}

                _sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                _sqlConnection.Dispose();
                _sqlCommand.Dispose();
            }
        }

        private void CreateClassicAccountBenefits(int bankAccountId, ClassicAccountBenefits classicAccountsbenefits)
        {
            try { }
            finally { }
        }

        private void CreateSilverAccountBenefits(int bankAccountId, SilverAccountBenefits silverAccountsbenefits)
        {
            try { }
            finally { }
        }

        private void CreateGoldAccountBenefits(int bankAccountId, GoldAccountBenefits goldAccountsbenefits)
        {
            try { }
            finally { }
        }
    }
}
