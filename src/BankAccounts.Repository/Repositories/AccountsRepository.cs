using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Services.AccountBenefits;
using AccountsAPI.Services.AccountBenefits.Classic;
using AccountsAPI.Services.AccountBenefits.Gold;
using System.Configuration;

namespace AccountsAPI.Repository.Repositories
{
    public class AccountsRepository : IRepository<Account>
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public AccountsRepository()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ToString());
        }

        public int Add(Account account)
        {
            try
            {
                var returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.CommandText = "sp_CreateAccount";
                _sqlCommand.Parameters.Add(new SqlParameter("@CustomerId", account.CustomerId));
                _sqlCommand.Parameters.Add(new SqlParameter("@AccountNumber", account.AccountNumber));
                _sqlCommand.Parameters.Add(new SqlParameter("@SortCode", account.SortCode));
                _sqlCommand.Parameters.Add(new SqlParameter("@Status", account.Status));
                _sqlCommand.Parameters.Add(returnValue);
                _sqlCommand.ExecuteNonQuery();
                return (int)returnValue.Value;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _sqlConnection.Dispose();
                _sqlCommand.Dispose();
            }
        }
    }
}
