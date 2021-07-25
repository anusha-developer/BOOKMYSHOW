using BOOKMYSHOW.Models;
using BOOKMYSHOW.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Service
{
    public class AdminService
    {

        private AdminRepositaryimpl adminRepositaryimpl;

            public AdminService()
            {
            adminRepositaryimpl = new AdminRepositaryimpl();
            }
            public Admin SaveAdmin(Admin admin)
            {
            return adminRepositaryimpl.CreateAdmin(admin);
            }
           public Admin GetAdminById(long admin_id)
           {
            return adminRepositaryimpl.GetAdminById(admin_id);
            }
          public Admin UpdateAdmin(long admin_id, Admin admin)
          {
            return adminRepositaryimpl.UpdateAdmin(admin_id ,admin);
          }
    }
}