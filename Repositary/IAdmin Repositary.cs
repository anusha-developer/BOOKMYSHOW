using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKMYSHOW.Repositary
{
    interface IAdmin_Repositary
    {
        //CREATE USER
        Admin CreateAdmin(Admin admin);

        Admin GetAdminById(long admin_id);

        Admin UpdateAdmin(long admin_id, Admin admin);


    }
}
