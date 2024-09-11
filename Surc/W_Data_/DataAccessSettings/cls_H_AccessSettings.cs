using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Data_.DataAccessSettings
{
    public class cls_H_AccessSettings
    {
        //ربما يجب إضافة شعار @قبل ال""
        public static SqlConnection conn_W = new SqlConnection("Server=.;Database=SystemMangerDB;User Id=sa;Password=sa123456;");

        public static SqlCommand command_W = new SqlCommand("", conn_W);

        public static void Change_DB_FileName_DAL(string _NPFilName)
        {
            if (conn_W.State == ConnectionState.Closed)
            {
                //ربما يجب إضافة شعار @قبل ال""
                conn_W.ConnectionString = "Server=.;Database=SystemMangerDB;User Id=sa;Password=sa123456;";
            }
        }

        public static void OpenConnect_W_DAL()
        {
            if (conn_W.State == ConnectionState.Closed) conn_W.Open();
        }
        public static void CloseConnect_W_DAL()
        {
            if (conn_W.State == ConnectionState.Open) conn_W.Close();
        }

        public static DataTable GetData_DAL(string _Select)
        {
            DataTable dt_1 = new DataTable();
            dt_1.Load(command_W.ExecuteReader());
            return dt_1;
        }
        public static void Run_W_SQL_DAL(string _SQL)
        {
            command_W.CommandText = _SQL;
            command_W.ExecuteNonQuery();
        }
        public static void SetBGF_W_DAL()
        {
            DataTable dt_2 = GetData_DAL("select * from Settings_bg_font");

            /*if (dt_2.Rows.Count < 1)
            {
                cls_W_DB.Run_W_SQL_DAL("insert into Settings_bg_font values(255,255,255,12)");
            }
            Tools_W_DAL.R = Convert.ToInt32(dt_2.Rows[0][0]);
            Tools_W_DAL.G = Convert.ToInt32(dt_2.Rows[0][1]);
            Tools_W_DAL.B = Convert.ToInt32(dt_2.Rows[0][2]);
            Tools_W_DAL.FS = Convert.ToInt32(dt_2.Rows[0][3]);*/
        }
    }
}
