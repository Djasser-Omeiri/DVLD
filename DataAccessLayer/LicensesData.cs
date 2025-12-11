using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LicensesData
    {
        public static int AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate
            , DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate
                            , ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                           VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate
                            , @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (string.IsNullOrEmpty(Notes))
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                Object scalar = command.ExecuteScalar();
                if (scalar != null && int.TryParse(scalar.ToString(), out int id))
                {
                    LicenseID = id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding license: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return LicenseID;
        }
        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate
            , DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Licenses 
                           SET ApplicationID = @ApplicationID, 
                               DriverID = @DriverID, 
                               LicenseClass = @LicenseClass, 
                               IssueDate = @IssueDate,
                               ExpirationDate= @ExpirationDate,
                               Notes= @Notes, PaidFees= @PaidFees,
                               IsActive= @IsActive,
                               IssueReason= @IssueReason,
                               CreatedByUserID= @CreatedByUserID
                               WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", string.IsNullOrWhiteSpace(Notes) ? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
        public static bool DeleteLicense(int LicenseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting license: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }

        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate
            , ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool exists = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    exists = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == DBNull.Value ? string.Empty : (string)reader["Notes"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking license existence: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }
        public static DataTable GetAllLicenses()
        {
            DataTable licensesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(licensesTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving licenses: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return licensesTable;
        }
        public static bool GetLicenseAllInfosByID(
            int ApplicationID,
            ref string className,
            ref string fullName,
            ref int licenseID,
            ref int nationalityCountryID,
            ref bool gendor,
            ref DateTime issueDate,
            ref byte issueReason,
            ref string notes,
            ref bool isActive,
            ref DateTime dateOfBirth,
            ref int driverID,
            ref DateTime expirationDate,
            ref bool isDetained)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select lc.ClassName,(p.FirstName + ' ' + p.SecondName + ' ' + p.ThirdName + ' ' + p.LastName)as FullName ,
                           l.LicenseID,p.NationalityCountryID,p.Gendor,l.IssueDate,l.IssueReason,l.Notes,l.IsActive,p.DateOfBirth,l.DriverID,l.ExpirationDate,
                           CASE WHEN exists (select top 1 1 from DetainedLicenses dl where dl.LicenseID=l.LicenseID and dl.IsReleased=0 ) 
                           then 1 else 0 end as IsDetained 
                           from Licenses l inner join LicenseClasses lc on lc.LicenseClassID=l.LicenseClass inner join Drivers d on d.DriverID=l.DriverID 
                           inner join People p on p.PersonID=d.PersonID Where l.ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    className = reader["ClassName"].ToString();
                    fullName = reader["FullName"].ToString();
                    licenseID = Convert.ToInt32(reader["LicenseID"]);
                    nationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    gendor = Convert.ToBoolean(reader["Gendor"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    issueReason = (byte)reader["IssueReason"];
                    notes = reader["Notes"].ToString();
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    isDetained = Convert.ToBoolean(reader["IsDetained"]);
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

        public static bool IsPersonHaveLicenseWithSameClass(int ApplicationID, int LicenseClass)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 1 from Licenses where ApplicationID=@ApplicationID and LicenseClass=@LicenseClass ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
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
        public static DataTable GetAllLicensesForHistory(int PersonID)
        {
            DataTable licensesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select l.LicenseID as [Lic.ID],ApplicationID as [App.ID],lc.ClassName,IssueDate as[Issue Date],
                           ExpirationDate as [Expiration Date],IsActive as [Is Active] from Licenses l 
                           join LicenseClasses lc on lc.LicenseClassID=l.LicenseClass join Drivers d on d.DriverID=l.DriverID where d.PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);   
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    licensesTable.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving licenses for history: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return licensesTable;
        }
    }
}
