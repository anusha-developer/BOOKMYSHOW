using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKMYSHOW.Repositary
{
    interface ISuperAdminRepositary
    {
        SuperAdmin CreateSuperAdmin(SuperAdmin superAdmin);

        SuperAdmin GetSuperAdminById(long Super_admin_id);

        SuperAdmin UpdateSuperAdmin(long super_admin_id, SuperAdmin superAdmin);

    }
}
