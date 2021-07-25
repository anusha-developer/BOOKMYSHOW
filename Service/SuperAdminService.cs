using BOOKMYSHOW.Models;
using BOOKMYSHOW.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Service
{
    public class SuperAdminService
    {
        private SuperAdminRepositaryimpl superAdminRepositaryimpl;

        public SuperAdminService()
        {
            superAdminRepositaryimpl = new SuperAdminRepositaryimpl();
        }
        public SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin)
        {
            return superAdminRepositaryimpl.CreateSuperAdmin(superAdmin);
        }
        public SuperAdmin GetSuperAdminById(long Super_admin_id)
        {
            return superAdminRepositaryimpl.GetSuperAdminById(Super_admin_id);
        }
        public SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin)
        {
            return superAdminRepositaryimpl.UpdateSuperAdmin(super_admin_id, superAdmin);
        }
    }
}
