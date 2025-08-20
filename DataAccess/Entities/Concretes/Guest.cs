using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public class Guest:BaseEntity
    {
        
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int? NationalId { get; set; }  // opsiyonel
        public string Email { get; set; } = default!;
        public int Phone { get; set; } = default!;
        public List<Reservation> Reservations { get; set; }  // Navigation property for related reservations
    }
}
