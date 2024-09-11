using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.DataAccessSettings;
using static System.Net.Mime.MediaTypeNames;
// Finish
namespace W_Data_.Application_D
{
    /// <summary>
    ///  W_ it is general class for all App another class will inherent and sherd
    /// </summary>
    public class clsApplication_D
    {
        public static bool GetAppInfoByID_D(int AppID, ref int AppPersonID,
           ref DateTime AppDate, ref int AppTypeID,
           ref byte AppStatus, ref DateTime LastStatusDate,
           ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @AppID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID_", AppID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    AppPersonID = (int)reader["ApplicantPersonID"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    AppTypeID = (int)reader["ApplicationTypeID"];
                    AppStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];


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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        //////////////////////////////////////////////////////////////////////

        public static DataTable GetAllApplications_D()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "select * from Applications order by ApplicationDate desc";

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
                //clsLogsToViwer.SendEventInLogViwer("GetAllApplications", enEventType.Error, ex);

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        //////////////////////////////////////////////////////////////////////

        public static int AddNewApp_D( int AppPersonID,
            DateTime AppDate,  int AppTypeID, byte AppStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {

            int AppID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@AppPersonID_,@AppDate_,@AppTypeID_,
                                      @AppStatus_,@LastStatusDate_,
                                      @PaidFees_,   @CreatedByUserID_);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID_", AppPersonID);
            command.Parameters.AddWithValue("@AppDate_",   AppDate);
            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);
            command.Parameters.AddWithValue("@AppStatus_", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate_",    LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees_",          PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID_",   CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }


            return AppID;
        }

        //////////////////////////////////////////////////////////////////////

        public static bool UpdateApp_D(int AppID, int AppPersonID,
            DateTime AppDate, int AppTypeID, byte AppStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicantPersonID = @AppPersonID_,
                                ApplicationDate =   @AppDate_,
                                ApplicationTypeID = @AppTypeID_,
                                ApplicationStatus = @AppStatus_, 
                                LastStatusDate =    @LastStatusDate_,
                                PaidFees =          @PaidFees_,
                                CreatedByUserID=    @CreatedByUserID_
                            where ApplicationID=    @AppID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID_", AppID);
            command.Parameters.AddWithValue("@AppPersonID_", AppPersonID);
            command.Parameters.AddWithValue("@AppDate_",   AppDate);
            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);
            command.Parameters.AddWithValue("@AppStatus_", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate_",    LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees_",          PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID_", CreatedByUserID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //clsLogsToViwer.SendEventInLogViwer("UpdateApplication", enEventType.Error, ex);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        //////////////////////////////////////////////////////////////////////

        public static bool DeleteApp_D(int AppID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Delete Applications where ApplicationID = @AppID_";
                                

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID_", AppID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //clsLogsToViwer.SendEventInLogViwer("DeleteApplication", enEventType.Error, ex);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        //////////////////////////////////////////////////////////////////////
        
        public static bool IsAppExist_D(int AppID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @AppID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID_", AppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
               // clsLogsToViwer.SendEventInLogViwer("IsApplicationExist", enEventType.Error, ex);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        //////////////////////////////////////////////////////////////////////

        public static bool DoesPersonHaveActiveApp_D(int AppPersonID, int AppTypeID)
        {

            //incase the ActiveApplication ID !=-1 return true.
            return (GetActiveAppID_D(AppPersonID, AppTypeID) != -1);
        }

        //////////////////////////////////////////////////////////////////////

    
        public static int GetActiveAppID_D(int AppPersonID, int AppTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);
            string query = "SELECT ActiveApplicationID = ApplicationID FROM Applications WHERE ApplicantPersonID = @AppPersonID_ and ApplicationTypeID=@AppTypeID_ and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID_", AppPersonID);
            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {

                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        //////////////////////////////////////////////////////////////////////

        public static int GetActiveAppIDForLicenseClass_D(int AppPersonID, int AppTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @AppPersonID_ 
                            and ApplicationTypeID=@AppTypeID_ 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID_
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID_", AppPersonID);
            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);
            command.Parameters.AddWithValue("@LicenseClassID_", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {

                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        //////////////////////////////////////////////////////////////////////
        
        public static bool UpdateStatus_D(int AppID, short NewStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus_, 
                                LastStatusDate = @LastStatusDate_
                            where ApplicationID=@AppID_;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID_", AppID);
            command.Parameters.AddWithValue("@NewStatus_", NewStatus);
            command.Parameters.AddWithValue("@LastStatusDate_", DateTime.Now);// WAS WITHOUT @


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

        //////////////////////////////////////////////////////////////////////



    }
}
