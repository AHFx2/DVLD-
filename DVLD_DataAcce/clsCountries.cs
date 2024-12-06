using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clsCountryData
    {
        static public DataTable GetCountries(){
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);


            string Qeury = "select * from countries";

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


        public static bool GetCountryByName(string Name, ref byte ID, ref string PhoneCode)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = "select * from countries where countries.CountryName = @Name";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            bool IsFailed = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFailed = true;
                    ID = Convert.ToByte(reader["CountryID"]);
                    PhoneCode = (reader["PhoneCode"] != DBNull.Value) ? (string)reader["PhoneCode"] : "Empty";
                }
                reader.Close();
            }

            catch { return false; }

            finally { connection.Close(); }

            return IsFailed;
        }

        public static bool GetCountryByID(ref string Name, byte ID, ref string PhoneCode)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = "select * from countries where countries.CountryID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            bool IsFailed = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFailed = true;
                    Name = (string)reader["CountryName"];
                    //Name =  (string)reader["CountryName"];


                    PhoneCode = (reader["PhoneCode"] != DBNull.Value) ? (string)reader["PhoneCode"] : "";
                }
                reader.Close();
            }

            catch { return false; }

            finally { connection.Close(); }

            return IsFailed;
        }


    }
}
