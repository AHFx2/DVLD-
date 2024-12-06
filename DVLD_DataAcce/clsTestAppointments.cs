using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsTestAppointments
    {

        public static DataTable GetAppointments()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable ApoinmmetsTable = new DataTable();
            string Query = "select  * from TestAppointments_View";

            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    ApoinmmetsTable.Load(reader);
                    reader.Close();
                }
                return ApoinmmetsTable;
            }

            catch { return ApoinmmetsTable; }

            finally { connection.Close(); }
        }

        public static DataTable GetAppointmentInfo(int AppoiID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable ApoinmmetsTable = new DataTable();
            string Query = "select * from TestAppointments_View where TestAppointments_View.TestAppointmentID = @AppoiID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AppoiID", AppoiID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ApoinmmetsTable.Load(reader);
                    reader.Close();
                }
                return ApoinmmetsTable;
            }

            catch { return ApoinmmetsTable; }

            finally { connection.Close(); }
        }
        public static int AddAppointment(int testTypeID, int lDLappID, DateTime appoinmentDate, double paidFees, int createduserID, byte isLock, int RetakeTestApplication = 0)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[TestAppointments]
                                    ([TestTypeID]
                                    ,[LocalDrivingLicenseApplicationID]
                                    ,[AppointmentDate]
                                    ,[PaidFees]
                                    ,[CreatedByUserID]
                                    ,[IsLocked]
                                    ,[RetakeTestApplicationID])
                                    VALUES
                                             (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @@RetakeTestApplicationID);
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", lDLappID);
            command.Parameters.AddWithValue("@AppointmentDate", appoinmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createduserID);
            command.Parameters.AddWithValue("@IsLocked", isLock);
            command.Parameters.AddWithValue("@RetakeTestApplicationID", (RetakeTestApplication == 0) ? (object)DBNull.Value : RetakeTestApplication);
            int ID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out ID))
                {
                }

            }

            catch { return ID; }

            finally { connection.Close(); }

            return ID;
        }

        public static bool UpdateAppointmentDate(int AppointmentID, DateTime appoinmentDate)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                          Update [dbo].[TestAppointments]
                        set
                        AppointmentDate = @AppointmentDate
                        where TestAppointments.TestAppointmentID = @AppointmentID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", appoinmentDate);
            
            try
            {
                connection.Open();
                int AffectedRow = command.ExecuteNonQuery();
                return AffectedRow > 0;
               

            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool GetAppointment(int AppointmentID, ref byte testTypeID, ref int lDLappID, ref DateTime AppointmenDate, ref double paidFees, ref int createduserID, ref byte isLock) {


            string Query = "select * from TestAppointments where TestAppointments.TestAppointmentID = @Appointment;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@Appointment", AppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testTypeID = Convert.ToByte(reader["TestTypeID"]);
                    lDLappID = Convert.ToInt16(reader["LocalDrivingLicenseApplicationID"]);
                    AppointmenDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    paidFees = Convert.ToInt16(reader["PaidFees"]);
                    createduserID = Convert.ToInt16(reader["CreatedByUserID"]);
                    isLock = Convert.ToByte(reader["IsLocked"]);
                    isFaild = true;
                }
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return isFaild;
        }
        public static bool IsTherePassedApointments(int LDLID, byte TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"
                           SELECT   1
                           FROM         TestAppointments INNER JOIN
                      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
					   where TestAppointments.LocalDrivingLicenseApplicationID = @LDLID
					 and TestTypeID = @TestTypeID
					 and TestResult = 1
                            ";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLID", LDLID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            int Result = 1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result == 1;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsThereFailedApointments(int LDLID, byte TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"
                           SELECT   1
                           FROM         TestAppointments INNER JOIN
                      Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
					   where TestAppointments.LocalDrivingLicenseApplicationID = @LDLID
					 and TestTypeID = @TestTypeID
					 and TestResult = 0
                            ";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLID", LDLID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            int Result = 1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result == 1;
            }

            catch { return false; }

            finally { connection.Close(); }
        }
        public static bool IsThereUnlockedAppointment(int LDLAppID, byte TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"select 1  from TestAppointments
                        where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID
						and TestAppointments.TestTypeID = @TestType
						and TestAppointments.IsLocked = 0
                       ";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestType", TestTypeID);

            int Result = 1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result == 1;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

        public static bool IsAppointmentlocked( int AppointmentID, int LDLAppID, byte TestTypeID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Qerury = @"select 1  from TestAppointments
                        where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID
						and TestAppointments.TestTypeID = @TestType
						and TestAppointments.IsLocked = 1 and 
                        TestAppointments.TestAppointmentID = @AppointmentID;
                       ";

            SqlCommand command = new SqlCommand(Qerury, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestType", TestTypeID);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

            int Result = 1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out _))
                {
                    Result = Convert.ToInt16(result);
                }

                return Result == 1;
            }

            catch { return false; }

            finally { connection.Close(); }
        }

    }
}
