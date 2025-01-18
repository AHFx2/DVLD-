using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
          ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
           ref short Gendor, ref string Address, ref string Phone, ref string Email,
           ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            { 
                   
                string query = @"USE [DVLD] 
                                 EXEC SP_GetPersonByID @PersonID = @ID;
                                 ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", PersonID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                ThirdName = clsDataAccessSettings.HandleNUllStrings(reader["ThirdName"]);


                                LastName = (string)reader["LastName"];
                                NationalNo = (string)reader["NationalNo"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];


                                //Email: allows null in database so we should handle null
                                Email = clsDataAccessSettings.HandleNUllStrings(reader["Email"]);

                                NationalityCountryID = (int)reader["NationalityCountryID"];

                                //ImagePath: allows null in database so we should handle null
                                ImagePath = clsDataAccessSettings.HandleNUllStrings(reader["ImagePath"]);

                                // The record was found
                                isFound = true;
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error: " + ex.Message);

                        isFound = false;
                    }
                }
        }
            return isFound;
        }


        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName,   ref DateTime DateOfBirth,
         ref short Gendor,ref string Address, ref string Phone, ref string Email,
         ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "USE [DVLD] GO EXEC SP_GetPersonByNatID @NatID = @NationalNo GO";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    ThirdName = clsDataAccessSettings.HandleNUllStrings(reader["ThirdName"]);


                    LastName = (string)reader["LastName"];
                    PersonID = (int)reader["PersonID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    Email = clsDataAccessSettings.HandleNUllStrings(reader["Email"]);

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    ImagePath = clsDataAccessSettings.HandleNUllStrings(reader["ImagePath"]);

                    // The record was found
                    isFound = true;
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewPerson( string FirstName,  string SecondName,
           string ThirdName,  string LastName,  string NationalNo,  DateTime DateOfBirth,
           short Gendor, string Address,  string Phone,  string Email,
            int NationalityCountryID,  string ImagePath)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"USE [DVLD]
                       
                            DECLARE	
		                            @PersonID int

                            SELECT	@NewPersonID = 1

                            EXEC	[dbo].[SP_AddNewPerson]
		                            @FirstName = @FirstName,
		                            @SecondName = @SecondName,
		                            @ThirdName = @ThirdName,
		                            @LastName = @LastName,
		                            @NationalNo = @NationalNo,
		                            @DateOfBirth = @DateOfBirth,
		                            @Gender = @Gendor,
		                            @Address = @Address,
		                            @PhoneNumber = @PhoneNumber,
		                            @Email = @Email,
		                            @NationalCountryID = @NationalCountryID,
		                            @ImagePath = @ImagePath,
		                            @NewPersonID = @PersonID OUTPUT

                            SELECT	@PersonID as N'NewPersonID'
 
";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
           
            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@PhoneNumber", Phone);
            
            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return PersonID;
        }



        public static bool UpdatePerson(int PersonID,  string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
           short Gendor, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

      

            string Query = @"USE [DVLD]
                               
                                EXEC	[dbo].[SP_UpdatePerson]
		                                @PersonID = @PersonID,
		                                @FirstName = @FirstName,
		                                @SecondName =  @SecondName,
		                                @ThirdName = @ThirdName,
		                                @LastName = @LastName,
		                                @NationalNo = @NationalNo,
		                                @DateOfBirth = @DateOfBirth,
		                                @Gender = @Gendor,
		                                @Address = @Address,
		                                @PhoneNumber = @Phone,
		                                @Email = @Email,
		                                @NationalCountryID = @NationalityCountryID,
		                                @ImagePath = @ImagePath

            ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

          
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"USE [DVLD]
                        GO
                        EXEC SP_GetPeople
                        GO
                            ";




            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"EXEC SP_DeletePerson
                             @PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            string Query = @"DECLARE @Dummy tinyint;
                            EXEC @Dummy =  SP_IsPersonExistsByID @PersonID = @PersonID
                            SELECT @Dummy;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                isFound = (bool)command.ExecuteScalar();

               
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DECLARE @Dummy BIT; EXEC @Dummy =  SP_IsPersonExistsByNatID @Natid = @NationalNo SELECT @Dummy;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                isFound = (bool)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
