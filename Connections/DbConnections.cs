using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;

namespace BOOKMYSHOW.Connections
{
    public class DbConnections
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection("data source=.; database=BOOk_MY_SHOW; integrated security=SSPI");
            return con;
        }
    }
}