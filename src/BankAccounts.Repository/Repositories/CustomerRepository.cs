using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Repository;
using BankAccounts.Repository.Entities;

namespace BankAccounts.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public CustomerRepository()
        {
            _sqlConnection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int customerId)
        {
            throw new NotImplementedException();
        }


        public int Add(Customer customer)
        {
            try
            {
                var returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand();
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@FirstName", customer.FirstName));
                _sqlCommand.Parameters.Add(new SqlParameter("@LastName", customer.LastName));
                _sqlCommand.Parameters.Add(new SqlParameter("@PersonalId", customer.Id));
                _sqlCommand.Parameters.Add(new SqlParameter("@DoB", customer.DoB));
                _sqlCommand.Parameters.Add(new SqlParameter("@AnnualGrossSalary", customer.AnnualGrossSalary));
                _sqlCommand .Parameters.Add(returnValue);
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

        public bool Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
