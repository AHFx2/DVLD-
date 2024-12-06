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
    public static class clsLicense
    {

        public static int AddLicense(int ApplicationID, int DriverID, byte LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, byte IsActive, byte IssueReason, int CreatdByUserID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                            DECLARE @InsertedID INT;

                            INSERT INTO [dbo].[Licenses]
                            (
                                [ApplicationID],
                                [DriverID],
                                [LicenseClass],
                                [IssueDate],
                                [ExpirationDate],
                                [Notes],
                                [PaidFees],
                                [IsActive],
                                [IssueReason],
                                [CreatedByUserID]
                            )
                            VALUES
                            (
                                @ApplicationID, 
                                @DriverID, 
                                @LicenseClass, 
                                @IssueDate, 
                                @ExpirationDate, 
                                @Notes, 
                                @PaidFees, 
                                @IsActive, 
                                @IssueReason, 
                                @CreatedByUserID
                            );

                            SET @InsertedID = SCOPE_IDENTITY();

                            IF @InsertedID IS NOT NULL
                            BEGIN
                                UPDATE Applications
                                SET ApplicationStatus = 3
                                WHERE ApplicationID = 
                                (
                                    SELECT Applications.ApplicationID
                                    FROM Applications 
                                    INNER JOIN LocalDrivingLicenseApplications
                                    ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                                    WHERE LocalDrivingLicenseApplications.ApplicationID = @ApplicationID
                                );

                                SELECT @InsertedID;
                            END;
                            ;
 ";

            SqlCommand commnad = new SqlCommand(Query, connection);
            commnad.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            commnad.Parameters.AddWithValue("@DriverID", DriverID);
            commnad.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            commnad.Parameters.AddWithValue("@IssueDate", IssueDate);
            commnad.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            commnad.Parameters.AddWithValue("@Notes", (Notes.Length > 0)? Notes: (object)DBNull.Value);
            commnad.Parameters.AddWithValue("@PaidFees", PaidFees);
            commnad.Parameters.AddWithValue("@IsActive", IsActive);
            commnad.Parameters.AddWithValue("@IssueReason", IssueReason);
            commnad.Parameters.AddWithValue("@CreatedByUserID", CreatdByUserID);

            int LicenseID = -1;
            try
            {
                connection.Open();

                object Result = commnad.ExecuteScalar();

                if (int.TryParse(Result.ToString(), out LicenseID)) { }
                return LicenseID;
            }

            catch { return LicenseID; }

            finally { connection.Close(); }
        }

        public static DataTable GetLicenseByLDLappID(int LDLID )
        {
            DataTable tb = new DataTable();
            string Query = @"SELECT    Licenses.LicenseID, LicenseClasses.ClassName, People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName, People.ImagePath ,Gendor = case  When People.Gendor = 0 then 'Male' else 'Female' end, Licenses.IssueDate, 
                      IssueReason = CASE WHEN Licenses.IssueReason = 1 THEN 'First Time' ELSE 'Other' END
, Licenses.Notes, IsActive = case when Licenses.IsActive = 1 then 'Yes' else 'No' end , People.DateOfBirth, Drivers.DriverID, Licenses.ExpirationDate, CASE WHEN EXISTS (SELECT 1 FROM DetainedLicenses WHERE DetainedLicenses.LicenseID = Licenses.LicenseID) THEN 'Yes' ELSE 'No' END AS ISDetained


FROM         Licenses INNER JOIN
                      LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID  INNER JOIN
                      Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                      People ON Drivers.PersonID = People.PersonID left JOIN
                      DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID

					  where Licenses.ApplicationID = (select LocalDrivingLicenseApplications.ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLappID)




";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@LDLappID", LDLID);

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

        public static DataTable GetLicenseByLicenseID(int LicenseID)
        {
            DataTable tb = new DataTable();


            string Query = @"select * from LicenseCards
where LicenseCards.LicenseID = @LicenseID";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static DataTable GetLicenseHistoryByPersonID(int PersonID)
        {
            DataTable tb = new DataTable();
            string Query = @"select * from LicensesHistory_View
                            where LicensesHistory_View.PersonID = @PersonID
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

        public static DataTable GetLicenseHistoryByNatID(string NatID)
        {
            DataTable tb = new DataTable();
            string Query = @"select * from LicensesHistory_View
                            where LicensesHistory_View.NationalNo = @NatID
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

        public static bool IsLicenseActive(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "select 1 from Licenses\r\nwhere Licenses.LicenseID = @LicenseID and Licenses.IsActive = 1";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            int Result = 0;

            try
            {

                connection.Open();
                object Res = command.ExecuteScalar();

                if (int.TryParse(Res.ToString(), out Result))
                {

                }

                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsEpiredLicense(int LicenseID) {

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "select 1 from Licenses where Licenses.LicenseID = @LicenseID and Licenses.ExpirationDate  < GETDATE();\r\n";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID ", LicenseID);

            int Result = 0;

            try
            {

                connection.Open();
                object Res = command.ExecuteScalar();

                if (int.TryParse(Res.ToString(), out Result))
                {

                }

                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool DEactiveLicense(int LicenseID){ 
            SqlConnection connection = new SqlConnection (DataAccessSettings.ConnectionString);

            string Query = @" update Licenses
 set Licenses.IsActive = 0
 where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand (Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            int AffectedRows = 0;
            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;

            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static int RenewLicense(int LicenseID, int ApplicationID ,string Notes, int PaidFees, int UserCreateITID) {

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"

                INSERT INTO [dbo].[Licenses]
                           ([ApplicationID]
                           ,[DriverID]
                           ,[LicenseClass]
                           ,[IssueDate]
                           ,[ExpirationDate]
                           ,[Notes]
                           ,[PaidFees]
                           ,[IsActive]
                           ,[IssueReason]
                           ,[CreatedByUserID])
                SELECT 
                    @ApplicationID,
                    DriverID, 
                    LicenseClass, 
                    GETDATE(), 
                    DATEADD(YEAR, ISNULL(
                        (SELECT LicenseClasses.DefaultValidityLength 
                         FROM LicenseClasses 
                         WHERE LicenseClasses.LicenseClassID = Licenses.LicenseClass), 0), 
                    GETDATE()),
                    @Notes, 
                    @PaidFees, 
                    1, 
                    2, 
                    @CreatedByUserID
                FROM Licenses
                WHERE Licenses.LicenseID = @LicenseID;
                select SCOPE_IDENTITY();
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID",LicenseID);
            command.Parameters.AddWithValue("@Notes", (Notes.Length == 0)? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", UserCreateITID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            int Result = 0;

            try
            {
                connection.Open();
                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Result))
                { }


                return Result;
            }

            catch { return Result; }

            finally { connection.Close(); }
        }
        
        public static int ReplaceLicense(int LicenseID, int ApplicationID , byte IssueReason, int UserCreateITID){

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                   INSERT INTO [dbo].[Licenses]
                              ([ApplicationID]
                              ,[DriverID]
                              ,[LicenseClass]
                              ,[IssueDate]
                              ,[ExpirationDate]
                              ,[Notes]
                              ,[PaidFees]
                              ,[IsActive]
                              ,[IssueReason]
                              ,[CreatedByUserID])
                   SELECT 
                       @ApplicationID,
                       DriverID, 
                       LicenseClass, 
			           IssueDate, 
                       ExpirationDate,
                       Notes, 
                       PaidFees, 
                       1, 
                       @IssueReason, 
                       @CreatedByUserID
                   FROM Licenses
                   WHERE Licenses.LicenseID = @LicenseID;

                select SCOPE_IDENTITY();
";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID",LicenseID);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", UserCreateITID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            int Result = 0;

            try
            {
                connection.Open();
                object res = command.ExecuteScalar();

                if (int.TryParse(res.ToString(), out Result))
                { }


                return Result;
            }

            catch { return Result; }

            finally { connection.Close(); }
        }

    }
}
