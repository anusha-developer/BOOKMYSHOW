using BOOKMYSHOW.Connections;
using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Repositary
{
    public class AdminRepositaryimpl : IAdmin_Repositary
    {
        SqlConnection con = null;
        public Admin CreateAdmin(Admin admin)
        {

            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
            
                SqlCommand cmd = new SqlCommand("INSERT INTO BMS_tbl_Admin values('" + admin.Adminname + "','" + admin.Email + "','" + admin.Password + "'," +
                    "'" + admin.Mobilenumber + "','" + admin.Login_time + "','" + admin.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return admin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return admin;
        }
    

    

        public Admin GetAdminById(long admin_id)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from BMS_tbl_Admin  where Admin_id=" + admin_id, con);
                Admin admin = new Admin();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    admin = new Admin();
                    admin.Admin_id = Convert.ToInt32(sdr["Admin_id"]);
                    admin.Adminname = Convert.ToString(sdr["Adminname"]);
                    admin.Email = Convert.ToString(sdr["Email"]);
                    admin.Password = Convert.ToString(sdr["Password"]);
                    admin.Mobilenumber = Convert.ToInt64(sdr["Mobilenumber"]);
                    admin.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    admin.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                    con.Close();

                    return admin;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Admin UpdateAdmin(long admin_id, Admin admin)
        {

            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BMS_tbl_Admin  SET  Adminname = '" + admin.Adminname + "', Email = '" + admin.Email + "', Password = '" + admin.Password + "', Mobilenumber = '" + admin.Mobilenumber + "', Login_time = '" + admin.Login_time + "',  Logout_time = '" + admin.Logout_time + "'WHERE admin_id =" + admin_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return admin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}