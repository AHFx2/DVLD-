using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsApplication
    {
     

        public static int AddApplication(int PersonID, DateTime ApplicationDate, byte ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                          
                                INSERT INTO [dbo].[Applications]
                                   ([ApplicantPersonID]
                                   ,[ApplicationDate]
                                   ,[ApplicationTypeID]
                                   ,[ApplicationStatus]
                                   ,[LastStatusDate]
                                   ,[PaidFees]
                                   ,[CreatedByUserID])
                                VALUES
                                   (@PersonID , @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                     select SCOPE_IDENTITY();                          

                                         ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            int ApplicationID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out ApplicationID))
                {
                }

            }

            catch { return ApplicationID; }

            finally { connection.Close(); }

            return ApplicationID;
        }

       
    }
}
