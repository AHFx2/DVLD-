using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsInternationalLicense
    {
        public static bool DoseHaveInternationalLicense(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"select 1 from InternationalLicenses
                inner join Applications on InternationalLicenses.ApplicationID = Applications.ApplicationID
                where Applications.ApplicantPersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            int Results = 0;
            try
            {
                connection.Open();

                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Results))
                {

                }

                return Results > 0;
            }

            catch { return false; }


            finally { connection.Close(); }
        }

        public static bool DoseDriverHaveDemandedLicense(int DriverID)
        {

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            // this query will check if the driver have the class three and dosen't have the international
            string Query = @"
                            SELECT    1
                        FROM         InternationalLicenses INNER JOIN
                      Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID

					  where Licenses.DriverID = @DriverID and Licenses.LicenseClass = 3 and InternationalLicenses.DriverID = @DriverID";

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@DriverID", DriverID);

            int Results = 0;
            try
            {
                connection.Open();

                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Results))
                {
                }

                return Results > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static int AddInternationalLicenseID(int ApplicationID, int DriverID, int InterNationalLicenseID, DateTime IssueDate, DateTime EpirationDate, byte IsActive, int UserCreateItID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
            INSERT INTO [dbo].[InternationalLicenses]
                       ([ApplicationID]
                       ,[DriverID]
                       ,[IssuedUsingLocalLicenseID]
                       ,[IssueDate]
                       ,[ExpirationDate]
                       ,[IsActive]
                       ,[CreatedByUserID])
                 VALUES
                      (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID)
                    select SCOPE_IDENTITY();
           ";

            SqlCommand commnad = new SqlCommand(Query, connection);
            commnad.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            commnad.Parameters.AddWithValue("@DriverID", DriverID);
            commnad.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", InterNationalLicenseID);
            commnad.Parameters.AddWithValue("@IssueDate", IssueDate);
            commnad.Parameters.AddWithValue("@ExpirationDate", EpirationDate);
            commnad.Parameters.AddWithValue("@IsActive", IsActive);
            commnad.Parameters.AddWithValue("@CreatedByUserID", UserCreateItID);

            int ID = -1;
            try
            {
                connection.Open();

                object result = commnad.ExecuteScalar();
                if (int.TryParse(result.ToString(), out ID))
                {

                }

                return ID;
            }

            catch { return ID; }

            finally { connection.Close(); }
        }

        public static DataTable GetLicenseByInterNationalLicenseID(int InterNationalLicenseID)
        {
            DataTable tb = new DataTable();


            string Query = @"
                           
            select * from InternationalLicenseCards
            where InternationalLicenseCards.InternationalLicenseID = InternationalLicenseID";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@InternationalLicenseID", InterNationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
            return tb;
        }


        public static DataTable GetInternationalLicenseHistoryByNatID(string NatID)
        {
            DataTable tb = new DataTable();
            string Query = @"
                            select * from InterntionalLicensesHistory_View
                            where InterntionalLicensesHistory_View.NationalNo = @NatID

                ";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@NatID", NatID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
            return tb;
        }
        public static DataTable GetInternationalLicenseHistoryByPersonID(int PersonID)
        {
            DataTable tb = new DataTable();
            string Query = @"
                           
                     select * from InterntionalLicensesHistory_View
                     where InterntionalLicensesHistory_View.PersonID = @PersonID

                ";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
            return tb;
        }

        public static DataTable GetInternationalLicenses()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable ApplicationsTable = new DataTable();

            string Query = @"select * from InternationalLicenses";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ApplicationsTable.Load(reader);
                }

                reader.Close();

                return ApplicationsTable;
            }
            catch { return ApplicationsTable; }

            finally { connection.Close(); }
        }

        public static int GetPersonIDByInternationalID(int InternationalID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                             select Drivers.PersonID from InternationalLicenses
                             inner join Drivers on Drivers.DriverID = InternationalLicenses.DriverID
                             where InternationalLicenses.InternationalLicenseID = @InternationalLicenseID
";

            SqlCommand command = new SqlCommand(@Query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalID);

            int Result = 0;
            try
            {
                connection.Open();


                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Result)) { }

                return Result;
            }

            catch { return 0; }

            finally { connection.Close(); }
        }
    }
}
