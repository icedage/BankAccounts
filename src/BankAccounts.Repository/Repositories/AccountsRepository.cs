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
    public class AccountsRepository : IRepository<Account>
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public AccountsRepository()
        {
            _sqlConnection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
        }

        public int Add(Account customer)
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
                _sqlCommand.ExecuteNonQuery();
                return accountId;
               
            }
            finally
            {
                _sqlConnection.Dispose();
                _sqlCommand.Dispose();
            }
        }
    
        public List<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account Get(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account customer)
        {
            throw new NotImplementedException();
        }
    }
}
