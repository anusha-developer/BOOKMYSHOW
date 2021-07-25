using BOOKMYSHOW.Models;
using BOOKMYSHOW.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOOKMYSHOW.Controllers
{
    public class AdminController : ApiController
    {
        private AdminService adminService;
        public AdminController()
        {
            adminService = new AdminService();
        }

        [HttpPost]
        [Route("api/Admin/save")]
        public Admin saveAdmin([FromBody] Admin admin)
        {

            try
            {
                return adminService.SaveAdmin(admin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return admin;
        }
        [HttpGet]
        [Route("api/Admin/GetById/{admin_id}")]
        public Admin fetchAdminById(int admin_id)
        {
            try
            {
                return adminService.GetAdminById(admin_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpPut]
        [Route("api/Admin/Update/{admin_id}")]
        public Admin UpdateAdmin(long admin_id, Admin admin)
        {
            try
            {
                return adminService.UpdateAdmin(admin_id, admin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
