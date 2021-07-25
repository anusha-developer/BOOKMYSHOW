using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Models
{
    public class SuperAdmin
    {
        private long superadmin_id;
        private string adminname;
        private string email;
        private string password;
        private long mobilenumber;
        private DateTime login_time;
        private DateTime logout_time;

        public long Superadmin_id { get => superadmin_id; set => superadmin_id = value; }
        public string Adminname { get => adminname; set => adminname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public long Mobilenumber { get => mobilenumber; set => mobilenumber = value; }
        public DateTime Login_time { get => login_time; set => login_time = value; }
        public DateTime Logout_time { get => logout_time; set => logout_time = value; }
    }
}