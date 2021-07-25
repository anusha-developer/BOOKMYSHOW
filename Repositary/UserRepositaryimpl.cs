using BOOKMYSHOW.Connections;
using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Repositary
{
    public class UserRepositaryimpl : IUserRepositary
    {
        SqlConnection con = null;
        public User CreateUser(User user)
        {

            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BMS_Tbl_USERS values('" + user.Username + "','" + user.Email+ "','" + user.PassWord + "'," +
                    "'" + user.Mobilenumber + "','" + user.Gender + "','" + user.Dob + "','" + user.Address + "','" + user.Created_date + "','" + user.Updated_date + "','" + user.Login_time + "','" + user.Logout_time + "')", con);
                cmd.ExecuteNonQuery();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return user;
        }

        public string DeleteUser(long user_id)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from BMS_Tbl_USERS WHERE UserId=" + user_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return " Deleted Sucessfully:" + user_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            List<User> UserList = new List<User>();
            try
            {
                User user = new User();
                con = DbConnections.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BMS_Tbl_USERS ", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    user = new User();
                    user.Userid = Convert.ToInt32(sdr["userid"]);
                    user.Username = Convert.ToString(sdr["Username"]);
                    user.Email = Convert.ToString(sdr["Email"]);
                    user.PassWord = Convert.ToString(sdr["PassWord"]);
                    user.Mobilenumber = Convert.ToInt64(sdr["Mobilenumber"]);
                    user.Gender = Convert.ToString(sdr["Gender"]);
                    user.Dob = Convert.ToDateTime(sdr["Dob"]);
                    user.Address = Convert.ToString(sdr["Address"]);
                    user.Created_date = Convert.ToDateTime(sdr["Created_date"]);
                    user.Updated_date = Convert.ToDateTime(sdr["Updated_date"]);
                    user.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    user.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                    UserList.Add(user);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return UserList;

        }
    

    public User GetUserById(long user_id)
    {
        try
        {
            con = DbConnections.CreateConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BMS_Tbl_USERS  where Userid=" + user_id, con);
            User user = new User();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                user = new User();
                user.Userid = Convert.ToInt32(sdr["userid"]);
                user.Username = Convert.ToString(sdr["Username"]);
                user.Email = Convert.ToString(sdr["Email"]);
                user.PassWord = Convert.ToString(sdr["PassWord"]);
                user.Mobilenumber = Convert.ToInt64(sdr["Mobilenumber"]);
                user.Gender = Convert.ToString(sdr["Gender"]);
                user.Dob = Convert.ToDateTime(sdr["Dob"]);
                user.Address = Convert.ToString(sdr["Address"]);
                user.Created_date = Convert.ToDateTime(sdr["Created_date"]);
                user.Updated_date = Convert.ToDateTime(sdr["Updated_date"]);
                user.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                user.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                con.Close();

                return user;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return null;
    }

        public User GetUserByUsername(string username)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from BMS_Tbl_USERS where Username='" + username + "'", con);
                User user = new User();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    user = new User();
                    user.Userid = Convert.ToInt32(sdr["userid"]);
                    user.Username = Convert.ToString(sdr["Username"]);
                    user.Email = Convert.ToString(sdr["Email"]);
                    user.PassWord= Convert.ToString(sdr["PassWord"]);
                    user.Mobilenumber = Convert.ToInt64(sdr["Mobilenumber"]);
                    user.Gender = Convert.ToString(sdr["Gender"]);
                    user.Dob = Convert.ToDateTime(sdr["Dob"]);
                    user.Address = Convert.ToString(sdr["Address"]);
                    user.Created_date = Convert.ToDateTime(sdr["Created_date"]);
                    user.Updated_date = Convert.ToDateTime(sdr["Updated_date"]);
                    user.Login_time = Convert.ToDateTime(sdr["Login_time"]);
                    user.Logout_time = Convert.ToDateTime(sdr["Logout_time"]);
                    con.Close();
                
                    return user;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public User LoginUser(string email, string password)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BMS_Tbl_USERS where email='" + email + "'and password='" + password + "' ", con);
                User user = new User();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    user = new User();
                    user.Email = Convert.ToString(sdr["email"]);
                    user.PassWord = Convert.ToString(sdr["password"]);
                    return user;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;

        }

        public User UpdateUser(long user_id, User user)
        {

            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BMS_Tbl_USERS  SET  Username = '" + user.Username + "', Email_Id = '" + user.Email+ "', PassWord = '" + user.PassWord + "', Mobilenumber = '" + user.Mobilenumber + "', Gender = '" + user.Gender + "',  Dob = '" + user.Dob + "', Address = '" + user.Address + "', Created_date = '" + user.Created_date + "', Updated_date = '" + user.Updated_date + "',Login_time = '" + user.Login_time + "',Logout_time = '" + user.Logout_time + "' WHERE Userid =" + user_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
    }

       
    
