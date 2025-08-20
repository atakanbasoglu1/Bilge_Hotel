using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public class Room:BaseEntity
    {
        
        public string RoomNumber { get; set; } = default!;
        public int Floor { get; set; }
        public int RoomTypeId { get; set; }
        public bool? HasBalcony { get; set; }   // null => RoomType default
        public bool? HasMinibar { get; set; }
    }
}
