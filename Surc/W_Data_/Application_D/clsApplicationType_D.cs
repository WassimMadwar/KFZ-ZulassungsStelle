using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.DataAccessSettings;
//Finish
namespace W_Data_.Application
{//Products 
    public class clsApplicationType_D
    {
        public static bool GetApplicationTypeInfoByID_D(int AppTypeID, ref string AppTypeTitle, ref float AppFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @AppTypeID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);
            
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    AppTypeTitle = (string)reader["ApplicationTypeTitle"];
                    AppFees = Convert.ToSingle(reader["ApplicationFees"]);

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

        /// ////////////////////////////////////////////////////////////////

        public static DataTable GetAllApplicationTypes_D()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes order by ApplicationTypeTitle";

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
               //clsLogsToViwer.SendEventInLogViwer("GetAllApplicationTypes", enEventType.Error, ex);

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        /// ////////////////////////////////////////////////////////////////

        public static int AddNewApplicationType_D(string AppTitle, float AppFees)
        {
            int ApplicationTypeID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@AppTitle_,@AppFees_)
                            
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppTitle_", AppTitle);
            command.Parameters.AddWithValue("@AppFees_", AppFees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }


            return ApplicationTypeID;

        }

        /// ////////////////////////////////////////////////////////////////

        public static bool UpdateApplicationType_D(int AppTypeID, string AppTitle, float AppFees)
        {

            int rowsAffected = 0;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @AppTypeTitle_,
                                ApplicationFees = @AppFees_
                                where ApplicationTypeID = @AppTypeID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppTypeID_", AppTypeID);
            command.Parameters.AddWithValue("@AppTypeTitle_", AppTitle);
            command.Parameters.AddWithValue("@AppFees_", AppFees);

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

        /// ////////////////////////////////////////////////////////////////

    }
}
