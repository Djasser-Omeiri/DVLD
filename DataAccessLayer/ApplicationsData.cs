using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ApplicationsData
    {
        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees
            , int CreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                           VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); 
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    ApplicationID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static bool GetApplicationByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees
            , ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("getID"+ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE Applications WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return rowsaffected > 0;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees
            , int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications set 
                           ApplicantPersonID=@ApplicantPersonID,
                           ApplicationDate=@ApplicationDate,
                           ApplicationTypeID=@ApplicationTypeID,
                           ApplicationStatus=@ApplicationStatus,
                           LastStatusDate=@LastStatusDate,
                           PaidFees=@PaidFees,
                           CreatedByUserID=@CreatedByUserID
                           Where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("this update"+ex.Message); }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllApplications()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * FROM Applications";
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
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return table;
        }

        public static bool SetStatus(int ApplicationID,int ApplicationStatus, DateTime LastStatusDate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications set
                           ApplicationStatus=@ApplicationStatus,
                           LastStatusDate=@LastStatusDate
                           Where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
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
    }
}
