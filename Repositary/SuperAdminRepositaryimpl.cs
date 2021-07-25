using BOOKMYSHOW.Connections;
using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Repositary
{
    public class SuperAdminRepositaryimpl : ISuperAdminRepositary
    {
        SqlConnection con = null;
        public SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO BMS_tbl_SuperAdmin values('" + superAdmin.Adminname + "','" + superAdmin.Email + "','" + superAdmin.Password + "'," +
                    "'" + superAdmin.Mobilenumber + "','" + superAdmin.Login_time + "','" + superAdmin.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return superAdmin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return superAdmin;
        



    }

    public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from BMS_tbl_SuperAdmin  where Superadmin_id=" + Super_admin_id, con);
                SuperAdmin superAdmin = new SuperAdmin();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    superAdmin = new SuperAdmin();
                    superAdmin.Superadmin_id = Convert.ToInt32(sdr["Superadmin_id"]);
                    superAdmin.Adminname = Convert.ToString(sdr["Adminname"]);
                    superAdmin.Email = Convert.ToString(sdr["Email"]);
                    superAdmin.Password = Convert.ToString(sdr["Password"]);
                    superAdmin.Mobilenumber = Convert.ToInt64(sdr["Mobilenumber"]);
                    superAdmin.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    superAdmin.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                   

                    return superAdmin;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        

    }

    public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BMS_tbl_SuperAdmin SET  Adminname = '" + superAdmin.Adminname + "', Email = '" + superAdmin.Email + "', Password = '" + superAdmin.Password + "', Mobilenumber = '" + superAdmin.Mobilenumber + "', Login_time = '" + superAdmin.Login_time + "',  Logout_time = '" + superAdmin.Logout_time + "'WHERE Superadmin_id =" + super_admin_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return superAdmin;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}