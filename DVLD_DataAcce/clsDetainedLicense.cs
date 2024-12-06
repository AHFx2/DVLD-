using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDetainedLicense
    {

        public static bool IsLicenseDetained(int  licenseId)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"select 1 from DetainedLicenses
                        where DetainedLicenses.LicenseID = @ID and DetainedLicenses.IsReleased = 0";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", licenseId);  

            int Result = 0;

            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (int.TryParse(res.ToString(), out Result)) { }

                return Result > 0;
            }

            catch { return  false; }

            finally { connection.Close(); }
        }

        public static int DetaineLicense(int LicenseID, double Fees, int usercreateIt, string notes)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[DetainedLicenses]
                           ([LicenseID]
                           ,[DetainDate]
                           ,[FineFees]
                           ,[CreatedByUserID]
                           ,[IsReleased]
                           ,[Notes])
                     VALUES
                           (@LicenseID, GETDATE(), @FineFees, @CreatedByUserID, 0, @Notes)
		                   select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@FineFees", Fees);
            command.Parameters.AddWithValue("@CreatedByUserID", usercreateIt);
            command.Parameters.AddWithValue("@Notes", (notes.Length == 0)? (object)DBNull.Value : notes);

            int Result = 0;

            try
            {
                connection.Open();

                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Result)) { }


                return Result;
            }

            catch { return  0; }

            finally { connection.Close(); }
        }
        public static bool ReleaseDetainedLicense(int DetainID, int usercreateIt, int ReleaseAppID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"UPDATE [dbo].[DetainedLicenses]
                            SET 
                            [IsReleased] = 1
                            ,[ReleaseDate] = GETDATE()
                            ,[ReleasedByUserID] = @CreatedByUserID
                            ,[ReleaseApplicationID] = @ReleaseAppID
                            WHERE DetainedLicenses.DetainID = @DetainID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@CreatedByUserID", usercreateIt);
            command.Parameters.AddWithValue("@ReleaseAppID", ReleaseAppID);

            int Result = 0;

            try
            {
                connection.Open();

                Result = command.ExecuteNonQuery();



                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }
        public static int GetLicenseFine(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"select DetainedLicenses.FineFees from DetainedLicenses
                        where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
         

            int Result = 0;

            try
            {
                connection.Open();

                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Result)) { }


                return Result;
            }

            catch { return  0; }

            finally { connection.Close(); }
        }

        public static DataTable GetDetainedInfo(int LicenseeID) {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"select * from DetainedLicenses
                        where LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                     dt.Load(reader); 
                }
                reader.Close();
                return dt;  
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
        }

        public static DataTable GetDetainedLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"select * from DetainedLicenses_View
                        ";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
                return dt;
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
        }
    }
}
