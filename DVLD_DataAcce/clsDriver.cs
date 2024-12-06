using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsDriver
    {
        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO [dbo].[Drivers]
           ([PersonID]
           ,[CreatedByUserID]
           ,[CreatedDate])
                 VALUES
                    (@PersonID, @CreatedByUserID, @CreatedDate)
                    select SCOPE_IDENTITY();
           ";

            SqlCommand commnad = new SqlCommand(Query, connection);
            commnad.Parameters.AddWithValue("@PersonID", PersonID);
            commnad.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            commnad.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int DriverID = -1;
            try
            {
                connection.Open();

                object result = commnad.ExecuteScalar();
                if ( int.TryParse(result.ToString(), out DriverID))
                {
                    
                }

                return DriverID;
            }

            catch { return DriverID; }

            finally { connection.Close(); }
        }

        public static bool IsPersonDriver(int PersonID) {  
        
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                            SELECT    1
                        FROM         Drivers INNER JOIN
                      People ON Drivers.PersonID = People.PersonID
					  where Drivers.PersonID = @PersonID
                        ";


            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            int Results = 0;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out Results))
                {

                }
                return Results > 0;


                
            }

            catch { return false; }


            finally { connection.Close(); }
            
        }

        public static bool GetDriverByPersonID(ref int DriverID, int PersonID, ref int UserCreateIT, ref DateTime CreatedDate) { 
        
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = "select * from Drivers where Drivers.PersonID = @PersonID";
            
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFailed  = false;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {

                    DriverID = Convert.ToInt16(reader["DriverID"]);
                    UserCreateIT = Convert.ToInt16(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    IsFailed = true;
                }
                reader.Close();
                return IsFailed;
            }


            catch { return false; }

            finally { connection.Close(); }
        }

        public static DataTable GetDrivers()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            DataTable table = new DataTable();

            string Query = @"select * from Drivers_View";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) { table.Load(reader); }

                return table;
            }
            catch { return new DataTable(); }

            finally { connection.Close(); }
        }
    }
}
