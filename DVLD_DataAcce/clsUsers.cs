using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    static public class clsUserData
    {

        public static bool GetUserByID(int ID, ref int PersonID, ref string Username, ref string Password, ref byte IsActive)
        {

            string Query = "select * from users where Users.UserID = @ID;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        Username = reader["UserName"].ToString();
                        PersonID = Convert.ToInt16(reader["PersonID"]);
                        Password = Convert.ToString(reader["Password"]);
                        IsActive = Convert.ToByte(reader["IsActive"]);
                        isFaild = true;
                    }
                }
                reader.Close();
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return true;
        }
        
        public static bool GetUserPersonByID(ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref DateTime BirthDate, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref byte NationalityCountryID, ref string ImagePath, int UserID, ref string Username, ref string Password, ref byte IsActive)
        {

            string Query = "select * from People  inner join Users on People.PersonID = Users.PersonID and UserID = @UserID;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    Username = reader["UserName"].ToString();
                    Password = Convert.ToString(reader["Password"]);
                    IsActive = Convert.ToByte(reader["IsActive"]);

                    PersonID = Convert.ToInt16(reader["PersonID"]);
                    NationalNo = reader["NationalNo"].ToString();
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
            return true;
        }

        public static bool GetUserByUsername(ref int ID, ref int PersonID,  string Username, ref string Password, ref byte IsActive)
        {

            string Query = "select * from users where Users.UserName = @Username;";

            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(Query, connection);

            bool isFaild = false;

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    ID = Convert.ToInt16(reader["UserID"]);
                    PersonID = Convert.ToInt16(reader["PersonID"]);
                    Password = Convert.ToString(reader["Password"]);
                    IsActive = Convert.ToByte(reader["IsActive"]);
                    isFaild = true;
                }
            }

            catch { return isFaild; }

            finally { connection.Close(); }
            return true;
        }


        public static int AddUser(int PersonID, string Username, string Password, byte IsActive)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Users
                             VALUES
                              (@PersonID,  @UserName, @Password, @IsActive);
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            int UserID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out UserID))
                {
                }

            }

            catch { return UserID; }

            finally { connection.Close(); }

            return UserID;
        }

        static public bool UpdateUser(int ID, int PersonID, string Username, string Password, byte IsActive)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            UPDATE [dbo].[Users]
                           SET [PersonID] = @PersonID
                              ,[UserName] = @UserName
                              ,[Password] = @Password
                              ,[IsActive] = @IsActive
                         WHERE Users.UserID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();

                return AffectedRows > 0;
            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool DeleteUser(int ID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            DELETE FROM [dbo].[Users]
                            WHERE Users.UserID = @ID";

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

        public static bool IsUserExsits(int ID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            select 1 FROM [dbo].[users]
                            WHERE users.UserID = @ID";

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


        public static bool IsUserExsitsByUserName(string Username)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            select 1 FROM [dbo].[users]
                            WHERE users.UserName = @Username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                return command.ExecuteScalar() != null;

            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static bool IsPersonUser(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                           
                            select 1 from Users
                            where Users.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                return command.ExecuteScalar() != null;

            }

            catch { return false; }

            finally { connection.Close(); }

        }

        public static DataTable GetUsers()
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            DataTable UsersTable = new DataTable();

            string Query = @"select Users.UserID ,People.PersonID, People.FirstName + ' ' + People.SecondName + ' ' + People.LastName as Name , Users.UserName, Users.IsActive from People
inner join Users on Users.PersonID = People.PersonID";

            SqlCommand command = new SqlCommand(Query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    UsersTable.Load(reader);
                }

                reader.Close();

                return UsersTable;
            }
            catch { return UsersTable; }

            finally { connection.Close(); }
        }


        static public bool UpdateUserPassword(int ID, string Password)
        {
            SqlConnection connection = new SqlConnection(DVLD_DataAccess.DataAccessSettings.ConnectionString);

            string Query = @"
                            UPDATE [dbo].[Users]
                            SET 
            [Password] = @Password
                                           
                            WHERE Users.UserID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Password", Password);

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
