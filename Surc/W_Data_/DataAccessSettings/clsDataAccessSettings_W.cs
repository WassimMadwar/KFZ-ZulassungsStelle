using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace W_Data_.DataAccessSettings
{
    public static class clsDataAccessSettings_W
    {
        //public static string ConnectionString = "Server=.;Database=W_5_DVLD;User Id=sa;Password=sa123456;";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

    }
}
