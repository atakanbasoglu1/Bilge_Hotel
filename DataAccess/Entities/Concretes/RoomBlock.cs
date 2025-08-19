using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 8) Oda Blokajı (Bakım/Kapama)
    public class RoomBlock
    {
        
        public int RoomId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Reason { get; set; } = default!; // Maintenance / OutOfService
    }
}
