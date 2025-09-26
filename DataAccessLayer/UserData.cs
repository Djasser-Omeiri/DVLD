using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserData
    {
        public static int AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $"INSERT INTO Users (UserName, Password, IsActive,PersonID) VALUES (@UserName, @Password, @IsActive,@PersonID) SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    UserID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return UserID;
        }
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
                }
                else isFound = false;
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE People WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return rowsaffected > 0;
        }
        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET PersonID=@PersonID, UserName=@UserName, Password=@Password, IsActive=@IsActive WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("update" + ex.Message); }
            finally { connection.Close(); }
            return rowsaffected > 0;
        }
        public static DataTable GetAllUsers(string columnName = null, string value = null)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT u.UserID,u.PersonID,(p.FirstName+' '+p.SecondName+' '+p.ThirdName+' '+p.LastName) as FullName ,u.UserName,u.IsActive FROM Users u inner join People p on p.PersonID=u.PersonID";
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
        public static bool GetUserByUsername(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserName=@UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
                }
                else isFound = false;
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool IsPersonLinkedWithUser(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                IsFound = (result != null);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool IsUserExistsWithUsername(string UserName) {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT 1 FROM Users WHERE UserName=@UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                IsFound = (result != null);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return IsFound;



        }
    }
}