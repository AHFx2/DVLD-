using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public static class clsLocalApplicationLicense
    {
        public static DataTable GetLocalApplicationsApplications()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable ApplicationsTable = new DataTable();

            string Query = @"select * from LocalDrivingLicenseApplications_View";

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

        public static int AddLocalApplicationsApplications(int ApplicationID, byte LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                              
                                INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                                           ([ApplicationID]
                                           ,[LicenseClassID])
                                     VALUES
                                                (@ApplicationID, @LicenseClassID);
                                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            int applicationID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out applicationID ))
                {
                }

            }

            catch { return applicationID ; }

            finally { connection.Close(); }

            return applicationID;
        }

        public static bool CancelApplication(int AppID)
        {

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);
            string Query = @"
                                update Applications
                                set Applications.ApplicationStatus = 2
                                where Applications.ApplicationID = 
                                (
                                select LocalDrivingLicenseApplications.ApplicationID from LocalDrivingLicenseApplications
                                where LocalDrivingLicenseApplicationID = @LDLAppID
                                )
                            ";


            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LDLAppID", AppID);
            int AffectedRows;
            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();
                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsThereActiveApplication(int PersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"    SELECT 1
                                FROM Applications inner join LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                                WHERE ApplicantPersonID = @PersonID 
                                  AND ApplicationStatus = 1
	                              AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            int Result = 0;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsApplicationCanceled(int LDLappID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"  
                                SELECT 1
                                FROM Applications inner join LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                                WHERE 
                                  ApplicationStatus = 2
	                              AND LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLappID";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLappID", LDLappID);

            int Result = 0;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsApplicationCompleted(int LDLappID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"
 
                                SELECT 1
                                FROM Applications inner join LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                                WHERE 
                                  ApplicationStatus = 3
	                              AND LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLappID";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLappID", LDLappID);

            int Result = 0;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result > 0;
            }

            catch { return false; }

            finally { connection.Close(); }
        }


        public static DataTable GetLocalAppInfo(int LDLAppID) {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable dt = new DataTable();
            string Query = @"   
                            select * from LocalAppInfo_View
                            where LocalAppInfo_View.LocalDrivingLicenseApplicationID = @LDLAppID
                        ";
                
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

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

        public static sbyte DetermineTheTestTypeToTake(int LDLAppID) { 
        
            // this function determin what test should the person take
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"SELECT 
    CASE
        WHEN EXISTS (
            SELECT 3
            FROM TestAppointments
            INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
            WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LDLID
            AND Tests.TestResult = 1
            AND TestAppointments.TestTypeID = 3
        ) THEN 3
        WHEN EXISTS (
            SELECT 2
            FROM TestAppointments
            INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
            WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LDLID
            AND Tests.TestResult = 1
            AND TestAppointments.TestTypeID = 2
        ) THEN 2
        WHEN EXISTS (
            SELECT 1
            FROM TestAppointments
            INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
            WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LDLID
            AND Tests.TestResult = 1
            AND TestAppointments.TestTypeID =1
        ) THEN 1
        ELSE 0 -- Not Pass any test
    END AS PassedTest;
";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@LDLID", LDLAppID );

            sbyte Result = -1;
            try
            {
                connection.Open();
                object Res = Command.ExecuteScalar();
                if (int.TryParse(Res.ToString(), out _)) { 
                    Result = Convert.ToSByte(Res);
                }

                return Result;
            }

            catch { return Result; }

            finally { connection.Close(); }
        }

        public static bool DoseLocalLicenseIssuedLicsnse(int LDLAppID) {

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string Query = @"select 1 from Licenses
                            inner join LocalDrivingLicenseApplications
                            on LocalDrivingLicenseApplications.ApplicationID = Licenses.ApplicationID
                            where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLappID";

            SqlCommand command = new SqlCommand(Query, connection);

            int Result = -1;
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

        public static bool DosePersonHaveThisLicense(int PersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string Quer = @"SELECT    1
                            FROM         Drivers INNER JOIN
                                        Licenses ON Drivers.DriverID = Licenses.DriverID
			                            where Licenses.LicenseClass = @LicenseID and PersonID = @PersonID";


            SqlCommand command = new SqlCommand(Quer, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseClassID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            int Result = -1;

            try
            {
                connection.Open();

                object Res = command.ExecuteScalar();

                if (int.TryParse(Res.ToString(), out Result)) { }

                return Result > 0;
            }   

            catch { return false; }
            finally { connection.Close(); }

        }

        public static bool DeleteLocalDrivingApplication(int LDLappID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            
                       DELETE FROM [dbo].[LocalDrivingLicenseApplications]
                     WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLappID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LDLappID", LDLappID);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }
    }
}
