using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.DataAccessSettings;
// Finish 
namespace W_Data_.License_D
{
    public class clsLicense_D
    {
        public static bool GetLicenseInfoByID_D(int LicenseID, ref int AppID, ref int DriverID, ref int LicenseClass,
        ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
        ref float PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID_", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    AppID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["DriverID"];


                }
                else
                {
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllLicenses_D()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM Licenses";

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
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetDriverLicenses_D(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID_
                            Order By IsActive Desc, ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID_", DriverID);

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
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        /////////////////////////////////////////////////////////////////////////

        public static int AddNewLicense_D(int ApplicationID, int DriverID, int LicenseClass,
                DateTime IssueDate, DateTime ExpirationDate, string Notes,
                float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"
                              INSERT INTO Licenses
                               (ApplicationID,
                                DriverID,
                                LicenseClass,
                                IssueDate,
                                ExpirationDate,
                                Notes,
                                PaidFees,
                                IsActive,IssueReason,
                                CreatedByUserID)
                         VALUES
                               (
                               @ApplicationID_,
                               @DriverID_,
                               @LicenseClass_,
                               @IssueDate_,
                               @ExpirationDate_,
                               @Notes_,
                               @PaidFees_,
                               @IsActive_,@IssueReason_, 
                               @CreatedByUserID_);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID_", ApplicationID);
            command.Parameters.AddWithValue("@DriverID_", DriverID);
            command.Parameters.AddWithValue("@LicenseClass_", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate_", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate_", ExpirationDate);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes_", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes_", Notes);

            command.Parameters.AddWithValue("@PaidFees_", PaidFees);
            command.Parameters.AddWithValue("@IsActive_", IsActive);
            command.Parameters.AddWithValue("@IssueReason_", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID_", CreatedByUserID);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LicenseID;

        }

        /////////////////////////////////////////////////////////////////////////

        public static bool UpdateLicense_D(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
          DateTime IssueDate, DateTime ExpirationDate, string Notes,
          float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"UPDATE Licenses
                           SET ApplicationID=@ApplicationID_, DriverID = @DriverID_,
                              LicenseClass = @LicenseClass_,
                              IssueDate = @IssueDate_,
                              ExpirationDate = @ExpirationDate_,
                              Notes = @Notes_,
                              PaidFees = @PaidFees_,
                              IsActive = @IsActive_,IssueReason=@IssueReason_,
                              CreatedByUserID = @CreatedByUserID_
                         WHERE LicenseID=@LicenseID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID_", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID_", ApplicationID);
            command.Parameters.AddWithValue("@DriverID_", DriverID);
            command.Parameters.AddWithValue("@LicenseClass_", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate_", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate_", ExpirationDate);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes_", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes_", Notes);

            command.Parameters.AddWithValue("@PaidFees_", PaidFees);
            command.Parameters.AddWithValue("@IsActive_", IsActive);
            command.Parameters.AddWithValue("@IssueReason_", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID_", CreatedByUserID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        /////////////////////////////////////////////////////////////////////////

        public static int GetActiveLicenseIDByPersonID_D(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"SELECT        Licenses.LicenseID
                            FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  
                             Licenses.LicenseClass = @LicenseClass_ 
                              AND Drivers.PersonID = @PersonID_
                              And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID_", PersonID);
            command.Parameters.AddWithValue("@LicenseClass_", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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


            return LicenseID;
        }

        /////////////////////////////////////////////////////////////////////////

        public static bool DeactivateLicense_D(int LicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"UPDATE Licenses
                           SET 
                              IsActive = 0
                             
                         WHERE LicenseID=@LicenseID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID_", LicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        /////////////////////////////////////////////////////////////////////////




        /////////////////////////////////////////////////////////////////////////
    }
}
