using AccountsAPI.Services.AccountBenefits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsAPI.Repository.Repositories
{
    public class SilverAccountBenefitsRepository : IRepository<SilverAccountBenefits>
    {
        private SqlCommand _sqlCommand;
        private SqlConnection _sqlConnection;

        public SilverAccountBenefitsRepository()
        {
            _sqlConnection = new SqlConnection("Server=(local);DataBase=Northwind;Integrated Security=SSPI");
        }
        
        public int Add(SilverAccountBenefits account)
        {
            try
            {
                var returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;

                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("sp_CreateSilverAccountBenefits", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@AccountId", account.AccountId));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesInternetBanking", account.IncludesInternetBanking));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesCheckBook", account.IncludesCheckBook));
                _sqlCommand.Parameters.Add(new SqlParameter("@PerdayCharges", account.Overdraft.PerdayCharges));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesOverdraftBuffer", account.Overdraft.IncludesOverdraftBuffer));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesGracePeriod", account.Overdraft.IncludesGracePeriod));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesEUCover", account.EuropeanTravelInsurance.IncludesEUCover));
                _sqlCommand.Parameters.Add(new SqlParameter("@TravelDays", account.EuropeanTravelInsurance.TravelDays));

                _sqlCommand.Parameters.Add(new SqlParameter("@EmergencyMedicalTravel", account.EuropeanTravelInsurance.EmergencyMedicalTravel));
                _sqlCommand.Parameters.Add(new SqlParameter("@CancellationTravel", account.EuropeanTravelInsurance.CancellationTravel));

                _sqlCommand.Parameters.Add(new SqlParameter("@PersonalAccidentalCover", account.EuropeanTravelInsurance.PersonalAccidentalCover));
                _sqlCommand.Parameters.Add(new SqlParameter("@BuggageCover", account.EuropeanTravelInsurance.BuggageCover));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesRoadSideAssistance", account.AABreakdownCover.IncludesRoadSideAssistance));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesAccidentalManagement", account.AABreakdownCover.IncludesAccidentalManagement));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesRelay", account.AABreakdownCover.UpgradeOptions.IncludesRelay));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesStayMobile", account.AABreakdownCover.UpgradeOptions.IncludesStayMobile));

                _sqlCommand.Parameters.Add(new SqlParameter("@HomeStart", account.AABreakdownCover.UpgradeOptions.HomeStart));
                _sqlCommand.Parameters.Add(new SqlParameter("@EmergencyCash", account.SentinelCardProtection.EmergencyCash));
                _sqlCommand.Parameters.Add(new SqlParameter("@HotelBillsOverseas", account.SentinelCardProtection.HotelBillsOverseas));
                _sqlCommand.Parameters.Add(new SqlParameter("@Claims", account.SentinelCardProtection.Claims));
                _sqlCommand.Parameters.Add(new SqlParameter("@MedicalAssistanceInAbroad", account.SentinelCardProtection.MedicalAssistanceInAbroad));
                _sqlCommand.Parameters.Add(new SqlParameter("@IncludesReplacements", account.SentinelCardProtection.IncludesReplacements));
                _sqlCommand.Parameters.Add(new SqlParameter("@HouseholdCover", account.SentinelCardProtection.HouseholdCover));
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
    }
}
