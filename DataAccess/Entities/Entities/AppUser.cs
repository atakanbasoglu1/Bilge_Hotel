using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities.Entities
{
    public class AppUser : IdentityUser
    {


        public DateTime? BirthDate { get; set; }
        public string? Address { get; set; }
    }
}
