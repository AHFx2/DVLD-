using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsTest
    {
     
        public static int AddTest(int AppoitmentId, byte TestResult, string Notes, int UserID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            INSERT INTO [dbo].[Tests]
                                ([TestAppointmentID]
                                ,[TestResult]
                                ,[Notes]
                                ,[CreatedByUserID])
                                VALUES
                                        (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)  

                                    if (SCOPE_IDENTITY() > 0)
										select SCOPE_IDENTITY() ;
										update TestAppointments
											set IsLocked = 1
											where TestAppointments.TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", AppoitmentId);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", (Notes.Length == 0)? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);
            int TestID = -1;
            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out TestID))
                {
                }

            }

            catch { return TestID; }

            finally { connection.Close(); }

            return TestID;
        }


        public static bool DosePassTheTest(int LDLAppID, byte TestTypeID)
        {

            {
                SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

                string Qerury = @"SELECT   1
                        FROM         Tests INNER JOIN
                      TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
					  where TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID
					  and TestAppointments.TestTypeID = @TestTypeID
                        and Tests.TestResult = 1";

                SqlCommand command = new SqlCommand(Qerury, connection);

                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
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
        }

    }
}
