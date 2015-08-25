using BankAccounts.Services.AccountBenefits.Classic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Repository.Repositories
{
    public class ClassicAccountBenefitsRepository : IRepository<ClassicAccountBenefits>
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public ClassicAccountBenefitsRepository()
        {
            _sqlConnection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
        }


        public List<ClassicAccountBenefits> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClassicAccountBenefits Get(int customerId)
        {
            throw new NotImplementedException();
        }

        public int Add(ClassicAccountBenefits account)
        {
            try
            {
                var returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;

                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("sp_CreateClassicAccount",_sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@AccountId", account.AccountId));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesInternetBanking", account.IncludesInternetBanking));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesCheckBook", account.IncludesCheckBook));
                _sqlCommand.Parameters.Add(new SqlParameter("@OverDraftBalance", account.Overdraft.OverDraftBalance));
                _sqlCommand.Parameters.Add(new SqlParameter("@PerdayCharges", account.Overdraft.PerdayCharges));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesOverdraftBuffer", account.Overdraft.IncludesOverdraftBuffer));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesGracePeriod", account.Overdraft.IncludesGracePeriod));
                _sqlCommand.Parameters.Add(returnValue);
                _sqlCommand.ExecuteNonQuery();
                return (int)returnValue.Value;

            }
            finally
            {
                _sqlConnection.Dispose();
                _sqlCommand.Dispose();
            }
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClassicAccountBenefits customer)
        {
            throw new NotImplementedException();
        }
    }
}
