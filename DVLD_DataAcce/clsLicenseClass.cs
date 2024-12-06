using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsLicenseClass
    {
        public static DataTable GetLicenseClasses()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable LicenseClassesTable = new DataTable();

            string Query = @"select * from LicenseClasses";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    LicenseClassesTable.Load(reader);
                }

                reader.Close();

                return LicenseClassesTable;
            }
            catch { return LicenseClassesTable; }

            finally { connection.Close(); }
        }


        public static bool GetLicenseByID(int LicenseClassID, ref string ClassName, ref string ClassDiscrption, ref byte MinimumAllowedAge, ref byte Length, ref int Fees) 
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                     select * from LicenseClasses
                     where LicenseClasses.LicenseClassID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", LicenseClassID);


            bool IsFailed = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) { 
                    ClassName = reader["ClassName"].ToString();
                    ClassDiscrption = reader["ClassDescription"].ToString();
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    Length = Convert.ToByte(reader["DefaultValidityLength"]);
                    Fees = Convert.ToInt16(reader["ClassFees"]);

                    IsFailed = true;
                }
                reader.Close ();
                return IsFailed;

            }

            catch { return false; }

            finally { connection.Close(); }
        }


        public static bool GetLicenseByName(ref int LicenseClassID, string ClassName, ref string ClassDiscrption, ref byte MinimumAllowedAge, ref byte Length, ref int Fees)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string Query = @"
                     select * from LicenseClasses
                     where LicenseClasses.ClassName = @Name";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", ClassName);


            bool IsSuccess = false;
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    LicenseClassID = Convert.ToInt16(reader["LicenseClassID"]);
                    ClassDiscrption = reader["ClassDescription"].ToString();
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    Length = Convert.ToByte(reader["DefaultValidityLength"]);
                    Fees = Convert.ToInt16(reader["ClassFees"]);

                    IsSuccess = true;
                }
                reader.Close();
                return IsSuccess;

            }

            catch { return false; }

            finally { connection.Close(); }
        }

    }
}
