using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InternationalLicensesData
    {
        public static int AddIDLA(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO InternationalLicenses (ApplicationID, DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID)
                           VALUES (@ApplicationID, @DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID); 
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    InternationalLicenseID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return InternationalLicenseID;
        }
        public static bool GetIDLAByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (Boolean)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static DataTable GetAllIDLAs(string columnName = null, string value = null)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select InternationalLicenseID as [Int.License ID],ApplicationID,DriverID,IssuedUsingLocalLicenseID as [L.License ID],IssueDate,ExpirationDate,IsActive from InternationalLicenses";
            if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(value))
            {
                query += $" WHERE {columnName} LIKE @Value";
            }
            SqlCommand command = new SqlCommand(query, connection);
            if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(value))
            {
                command.Parameters.AddWithValue("@Value", $"{value}%");
            }
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
        public static DataTable GettAllIDLAsForHistory(int PersonID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select InternationalLicenseID as [Int.License ID],ApplicationID,IssuedUsingLocalLicenseID as [L.License ID],IssueDate as [Issue Date],ExpirationDate as [Expiration Date],IsActive as [Is Active] from InternationalLicenses i join Drivers d on d.DriverID=i.DriverID where d.PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
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
        public static bool GetIDLAllInfosByID(
            int InternationalLicenseID,
            ref int ApplicationID,
            ref string FullName,
            ref int IssuedUsingLocalLicenseID,
            ref int NationalityCountryID,
            ref bool Gendor,
            ref DateTime IssueDate,
            ref bool IsActive,
            ref DateTime DateOfBirth,
            ref int DriverID,
            ref DateTime ExpirationDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select ll.InternationalLicenseID ,ll.ApplicationID,(p.FirstName + ' ' + p.SecondName + ' ' + p.ThirdName + ' ' + p.LastName)as FullName ,
                           ll.IssuedUsingLocalLicenseID,p.NationalityCountryID,p.Gendor,ll.IssueDate,ll.IsActive,p.DateOfBirth,ll.DriverID,ll.ExpirationDate
                           from InternationalLicenses ll inner join Drivers d on d.DriverID=ll.DriverID 
                           inner join People p on p.PersonID=d.PersonID Where ll.InternationalLicenseID=@InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    FullName = reader["FullName"].ToString();
                    IssuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    Gendor = Convert.ToBoolean(reader["Gendor"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool isInternationalLicenseExists(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 1 from InternationalLicenses where IssuedUsingLocalLicenseID=@LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }
    }
}
