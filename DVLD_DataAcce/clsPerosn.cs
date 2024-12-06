using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace DVLD_DataAccess
{
    static public class clsPersonData
    {

        // making the crud
        /*
            create
            read
            update 
            delete
         */


        public static bool GetPersonByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref DateTime BirthDate, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath)
        {

            string Query = "select * from People where People.PersonID = @ID;";

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
                    NationalNo = reader["NationalNo"].ToString();
                    FirstName =  reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName =  reader["ThirdName"].ToString();
                    LastName =   reader["LastName"].ToString();
                    BirthDate = (DateTime)reader["DateOfBirth"];
                    Address = reader["Address"].ToString();
                    Gendor = (byte)reader["Gendor"];
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    ImagePath = reader["ImagePath"].ToString();
                    NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);
                    isFaild = true;
                }
                reader.Close();
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return isFaild;
        }


        public static bool GetPersonByNatID(ref int ID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                            ref DateTime BirthDate, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath)
        {

            string Query = "select * from People where People.NationalNo = @NatID;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@NatID", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NationalNo = reader["NationalNo"].ToString();
                    ID = Convert.ToInt16(reader["PersonID"]);
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    BirthDate = (DateTime)reader["DateOfBirth"];
                    Address = reader["Address"].ToString();
                    Gendor = (byte)reader["Gendor"];
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    ImagePath = reader["ImagePath"].ToString();
                    NationalityCountryID = Convert.ToByte(reader["NationalityCountryID"]);
                    isFaild = true;
                }
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return isFaild;
        }

        public static int AddPerson(string NationalNo, string Firstname, string Secondname, string Thirdname, string Lastname,
                                DateTime BirthDate, byte Gendor, string Address, string Phone, string Email, byte NationlityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People
                             VALUES
                              (@NationalNo,  @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address,
                              @Phone, @Email, @NationalityCountryID, @ImagePath);
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", Firstname);
            command.Parameters.AddWithValue("@SecondName", Secondname);
            command.Parameters.AddWithValue("@ThirdName", Thirdname);
            command.Parameters.AddWithValue("@LastName", Lastname);
            command.Parameters.AddWithValue("@DateOfBirth", BirthDate);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationlityCountryID);

            command.Parameters.AddWithValue("@ImagePath", (ImagePath == null) ? (object)DBNull.Value : ImagePath);
            int PersonID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                }

            }

            catch { return PersonID; }

            finally { connection.Close(); }
           
            return PersonID;
        }

        static public bool UpdatePerson(int ID, string NationalNo, string Firstname, string Secondname, string Thirdname, string Lastname,
                                DateTime BirthDate, byte Gendor, string Address, string Phone, string Email, byte NationlityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            UPDATE [dbo].[People]
                            SET [NationalNo] = @NationalNo
                                            ,[FirstName] = @FirstName
                                            ,[SecondName] = @SecondName
                                            ,[ThirdName] = @ThirdName
                                            ,[LastName] = @LastName
                                            ,[DateOfBirth] = @DateOfBirth
                                            ,[Gendor] = @Gendor 
                                            ,[Address] = @Address 
                                            ,[Phone] = @Phone
                                            ,[Email] = @Email
                                            ,[NationalityCountryID] = @NationalityCountryID
                                            ,[ImagePath] = @ImagePath
                            WHERE People.PersonID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", Firstname);
            command.Parameters.AddWithValue("@SecondName", Secondname);
            command.Parameters.AddWithValue("@ThirdName", Thirdname);
            command.Parameters.AddWithValue("@LastName", Lastname);
            command.Parameters.AddWithValue("@DateOfBirth", BirthDate);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationlityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();
                
                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool DeletePerson(int ID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            DELETE FROM [dbo].[People]
                            WHERE People.PersonID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool IsPersonExsits(int ID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            select 1 FROM [dbo].[People]
                            WHERE People.PersonID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                return command.ExecuteScalar() != null;

            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool IsPersonNatID(string NatID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            select 1 FROM [dbo].[People]
                            WHERE People.NationalNo = @NatID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NatID", NatID);

            try
            {
                connection.Open();
                return command.ExecuteScalar() != null;

            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static DataTable GetPeople()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable Peopletable = new DataTable();

            string Query = @"SELECT
                   PersonID, NationalNo, FirstName, SecondName, 
                   ThirdName, LastName, DateOfBirth, 
                   Gendor = case when Gendor = 0 Then 'Male' else 'Female' end,
                   Address, Phone, Email, NationalityCountryID, ImagePath FROM People ";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) {
                    Peopletable.Load(reader);
                }

                reader.Close();

                return Peopletable;
            }
            catch { return Peopletable; }

            finally { connection.Close(); }
        }

    }
}
