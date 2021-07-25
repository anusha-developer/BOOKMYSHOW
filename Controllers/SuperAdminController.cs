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
    public class SuperAdminController : ApiController
    {
        private SuperAdminService superAdminService;
        public SuperAdminController()
        {
            superAdminService = new SuperAdminService();
        }

        [HttpPost]
        [Route("api/SuperAdmin/save")]
        public SuperAdmin CreateSuperAdmin([FromBody] SuperAdmin superAdmin)
        {

            try
            {
                return superAdminService.CreateSuperAdmin(superAdmin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return superAdmin;
        }
        [HttpGet]
        [Route("api/SuperAdmin/GetById/{Super_admin_id}")]
        public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            try
            {
                return superAdminService.GetSuperAdminById(Super_admin_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpPut]
        [Route("api/SuperAdmin/UpdateById/{super_admin_id}")]
        public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {
            try
            {
                return superAdminService.UpdateSuperAdmin(super_admin_id, superAdmin);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
