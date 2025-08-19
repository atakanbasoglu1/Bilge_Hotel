using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Entities
{
    public class AppUserRole : IdentityRole
    {
        public string RoleDescription { get; set; }

    }
}
