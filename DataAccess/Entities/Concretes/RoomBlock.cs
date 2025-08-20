using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    // Oda Blokajı (Bakım/Kapama)
    public class RoomBlock:BaseEntity
    {
        
        public int RoomId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Reason { get; set; } = default!; // Maintenance / OutOfService
    }
}
