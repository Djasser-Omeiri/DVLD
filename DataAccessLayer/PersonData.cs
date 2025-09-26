using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PersonData
    {
        public static int AddPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth
            , bool Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                           VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath); 
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    PersonID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine("add" + ex.Message); }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth
            , ref bool Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : "";
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (bool)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : "";
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("getTHIS" + ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool IsPersonExistsWithNationalNo(string NationalNo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)

                    isFound = true;

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool DeletePerson(int PersonID)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE People WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("exist" + ex.Message); }
            finally { connection.Close(); }
            return rowsaffected > 0;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth
            , bool Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE People set 
                           NationalNo=@NationalNo,
                           FirstName=@FirstName,
                           SecondName=@SecondName,
                           ThirdName=@ThirdName,
                           LastName=@LastName,
                           DateOfBirth=@DateOfBirth,
                           Gendor=@Gendor,
                           Address=@Address,
                           Phone=@Phone,Email=@Email,
                           NationalityCountryID=@NationalityCountryID,
                           ImagePath=@ImagePath 
                           Where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Update" + ex.Message); }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllPersons()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM People";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("getall" + ex.Message); }
            finally { connection.Close(); }
            return table;
        }

        public static DataTable GetAllPersonsCustom(string columnName = null, string value = null)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select p.PersonID ,p.NationalNo,p.FirstName,p.SecondName,p.ThirdName,p.LastName,CASE 
                            WHEN p.Gendor = 1 THEN 'Male'
                            ELSE 'Female'
                            END AS Gendor ,p.DateOfBirth,c.CountryName as Nationality, p.Phone, p.Email FROM People p INNER JOIN Countries c ON p.NationalityCountryID=c.CountryID";

            if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(value))
            {
                query += $" WHERE {columnName} LIKE @Value";
            }
            SqlCommand command = new SqlCommand(query, connection);
            if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(value))
                command.Parameters.AddWithValue("@Value", $"{value}%");
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return table;
        }

        public static bool GetPersonCustom(string columnName, string value , ref int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth
            , ref bool Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $@"Select top 1 p.PersonID ,p.NationalNo,p.FirstName,p.SecondName,p.ThirdName,p.LastName,p.Gendor,p.DateOfBirth,c.CountryName as Nationality, p.Phone, p.Email,p.NationalityCountryID,p.Address,p.ImagePath FROM People p INNER JOIN Countries c ON p.NationalityCountryID=c.CountryID
                            WHERE {columnName} LIKE @Value";

            SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value", $"{value}");
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"]; 
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : "";
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (bool)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : "";
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";
                }

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return IsFound;
        }
    }
}
