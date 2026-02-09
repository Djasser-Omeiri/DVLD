using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LocalDrivingLicenseApplicationsData
    {
        public static int AddLDLA(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                           VALUES (@ApplicationID, @LicenseClassID); 
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    LocalDrivingLicenseApplicationID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return LocalDrivingLicenseApplicationID;
        }
        public static bool GetLDLAByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static int GetApplicationIDByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", LocalDrivingLicenseApplicationID);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    ApplicationID = Convert.ToInt32(result);
            }

            return ApplicationID;
        }
        public static bool DeleteLDLA(int LocalDrivingLicenseApplicationID)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return rowsaffected > 0;
        }

        public static bool UpdateLDLA(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications set 
                           LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
                           ApplicationID=@ApplicationID,
                           LicenseClassID=@LicenseClassID
                           Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static DataTable GetAllLDLAs(string columnName = null, string value = null)
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select LocalDrivingLicenseApplicationID as [L.D.L.AppID] , ClassName,NationalNo,FullName,ApplicationDate,PassedTestCount as [Passed Tests], Status  from LocalDrivingLicenseApplications_View";
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

        public static bool IsPersonLinkedWithSameClass(int ApplicantPersonID, int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select top 1 1 from LocalDrivingLicenseFullApplications_View where ApplicantPersonID=@ApplicantPersonID and LicenseClassID=@LicenseClassID and ApplicationStatus <> 2";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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
        public static bool getAllInfos(int LocalDrivingLicenseApplicationID, ref string ClassName, ref int PassedTestCount, ref int ApplicationID, ref string Status, ref decimal PaidFees, ref string ApplicationTypeTitle, ref string FullName, ref DateTime ApplicationDate, ref DateTime LastStatusDate, ref string UserName, ref int ApplicantPersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT fv.LocalDrivingLicenseApplicationID,v.ClassName,v.PassedTestCount,
                           fv.ApplicationID,v.Status,fv.PaidFees,at.ApplicationTypeTitle,v.FullName,fv.ApplicantPersonID,fv.ApplicationDate,
                           fv.LastStatusDate,u.UserName from LocalDrivingLicenseFullApplications_View fv 
                           inner join LocalDrivingLicenseApplications_View v on v.LocalDrivingLicenseApplicationID=fv.LocalDrivingLicenseApplicationID 
                           inner join ApplicationTypes at on at.ApplicationTypeID=fv.ApplicationTypeID 
                           inner join Users u on u.UserID=fv.CreatedByUserID where fv.LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ClassName = reader["ClassName"].ToString();
                    PassedTestCount = (int)reader["PassedTestCount"];
                    ApplicationID = (int)reader["ApplicationID"];
                    Status = reader["Status"].ToString();
                    PaidFees = (decimal)reader["PaidFees"];
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    FullName = reader["FullName"].ToString();
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    UserName = reader["UserName"].ToString();
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static bool getPassedTestCount(int LocalDrivingLicenseApplicationID, ref int PassedTestCount)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT PassedTestCount from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PassedTestCount = (int)reader["PassedTestCount"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {
            byte TotalTrialsPerTest = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                       ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return TotalTrialsPerTest;

        }

    }
}
