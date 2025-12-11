using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DetainedLicensesData
    {
        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int DetainID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID)
                            VALUES (@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if (ReleasedByUserID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            if (ReleaseApplicationID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int interedId))
                {
                    DetainID = interedId;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, Decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update DetainedLicenses set LicenseID=@LicenseID,DetainDate=@DetainDate,
                          FineFees=@FineFees,CreatedByUserID=@CreatedByUserID,IsReleased=@IsReleased,
                          ReleaseDate=@ReleaseDate,ReleasedByUserID=@ReleasedByUserID,ReleaseApplicationID=@ReleaseApplicationID
                          where DetainID=@DetainID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if (ReleasedByUserID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            if (ReleaseApplicationID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
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

        public static bool IsDetainedLicenseExists(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $"select top 1 1 from DetainedLicenses where LicenseID=@LicenseID and IsReleased=0 ";
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

        public static bool GetDetainedLicenseByID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref Decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $"SELECT * from DetainedLicenses where LicenseID=@LicenseID and IsReleased=0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    DetainID = Convert.ToInt32(reader["DetainID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToDecimal(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);
                    ReleaseDate = reader["ReleaseDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReleaseDate"]) : DateTime.MinValue;
                    ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? (int?)reader["ReleasedByUserID"] : null;
                    ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? (int?)reader["ReleaseApplicationID"] : null;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return isFound;

        }
    }
}
