using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W_Data_.DataAccessSettings;

namespace W_Data_.License_D
{
    public class clsLicenseClass_D
    {
        public static bool GetLicenseClassInfoByID_D(int LicenseClassID,
            ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge,
            ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID_", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

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

        public static bool GetLicenseClassInfoByClassName_D(string ClassName, ref int LicenseClassID,
            ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName_", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

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

        /////////////////////////////////////////////////////////////////////////

        public static DataTable GetAllLicenseClasses_D()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = "SELECT * FROM LicenseClasses order by ClassName";

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

        public static int AddNewLicenseClass_D(string ClassName, string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Insert Into LicenseClasses 
                                    (ClassName,ClassDescription,MinimumAllowedAge, 
                                     DefaultValidityLength,ClassFees)
                            Values (@ClassName_,@ClassDescription_,@MinimumAllowedAge_, 
                                    @DefaultValidityLength_,@ClassFees_) 
            
                            where LicenseClassID = @LicenseClassID_;
                            SELECT SCOPE_IDENTITY();";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName_", ClassName);
            command.Parameters.AddWithValue("@ClassDescription_", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge_", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength_", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees_", ClassFees);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseClassID = insertedID;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                connection.Close();
            }


            return LicenseClassID;

        }

        /////////////////////////////////////////////////////////////////////////

        public static bool UpdateLicenseClass_D(int LicenseClassID, string ClassName,
            string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings_W.ConnectionString);

            string query = @"Update  LicenseClasses  
                            set ClassName = @ClassName_,
                                ClassDescription = @ClassDescription_,
                                MinimumAllowedAge = @MinimumAllowedAge_,
                                DefaultValidityLength = @DefaultValidityLength_,
                                ClassFees = @ClassFees_
                                where LicenseClassID = @LicenseClassID_";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID_", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName_", ClassName);
            command.Parameters.AddWithValue("@ClassDescription_", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge_", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength_", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees_", ClassFees);


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

    }
}
