using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsTestsTypes
    {

        static public DataTable GetAllTestTypes()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataSettings.ConnectionString);


            string Qeury = "select  * from TestTypes order byt TestTypeID";

            SqlCommand command = new SqlCommand(Qeury, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable AllTestTypes = new DataTable();

                if (reader.HasRows)
                {
                    AllTestTypes.Load(reader);
                }

                reader.Close();
                return AllTestTypes;
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }
        }

        static public bool UpdateTestType(int ID, string Title, string Description, double Fee)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataSettings.ConnectionString);

            string Query = @"
                           
                       UPDATE [dbo].[TestTypes]
                       SET [TestTypeTitle] = @Title
                          ,[TestTypeDescription] = @Description
                          ,[TestTypeFees] = @Fees
                     WHERE TestTypes.TestTypeID = @ID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fee);


            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }


        public static bool GetTestTypeByID(int ID, ref string Title, ref string Description, ref double Fee)
        {

            string Query = "select * from TestTypes where TestTypes.TestTypeID = @ID;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    Title = reader["TestTypeTitle"].ToString();
                    Description = reader["TestTypeDescription"].ToString();
                    Fee = Convert.ToDouble(reader["TestTypeFees"]);

                    isFaild = true;
                }
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return isFaild;
        }


    }
}

