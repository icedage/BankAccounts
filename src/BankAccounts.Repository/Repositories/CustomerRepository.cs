using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsAPI.Repository;
using AccountsAPI.Repository.Entities;
using System.Configuration;

namespace AccountsAPI.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public CustomerRepository()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Accounts"].ToString());
        }

        public int Add(Customer customer)
        {
            try
            {
                var returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.CommandText = "sp_CreateCustomer";
                _sqlCommand.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                _sqlCommand.Parameters.Add(new SqlParameter("@Nationality", customer.Nationality));
                _sqlCommand.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                _sqlCommand.Parameters.Add(new SqlParameter("@PersonalId", customer.Id));
                _sqlCommand.Parameters.Add(new SqlParameter("@DoB", customer.BirthDate));
                _sqlCommand.Parameters.Add(new SqlParameter("@AnnualGrossSalary", customer.AnnualGrossSalary));
                _sqlCommand.Parameters.Add(new SqlParameter("@PostCode", "Test"));
                _sqlCommand.Parameters.Add(new SqlParameter("@Address", "Test"));
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
