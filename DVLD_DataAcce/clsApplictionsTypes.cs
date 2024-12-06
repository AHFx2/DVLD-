using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsApplictionsTypes
    {
        static public DataTable GetApplictionTypes()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);


            string Qeury = "select  * from ApplicationTypes";

            SqlCommand command = new SqlCommand(Qeury, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable CountriesTable = new DataTable();

                if (reader.HasRows)
                {
                    CountriesTable.Load(reader);
                }

                reader.Close();
                return CountriesTable;
            }

            catch { return null; }

            finally { connection.Close(); }
        }

        static public bool UpdateApplictionType(int ID, string Title, double Fee)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                           
                            UPDATE [dbo].[ApplicationTypes]
                               SET [ApplicationTypeTitle] = @Title
                                  ,[ApplicationFees] = @Fee
                             WHERE ApplicationTypes.ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fee", Fee);
           

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }


        public static bool GetApplicationTypeByID(byte ID, ref string Title, ref double Fee)
        {

            string Query = "select * from ApplicationTypes where ApplicationTypes.ApplicationTypeID = @ID;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    Title = reader["ApplicationTypeTitle"].ToString();
                    Fee = Convert.ToDouble(reader["ApplicationFees"]);
                    
                    isFaild = true;
                }
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return isFaild;
        }


    }
}
