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
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = default!;
        public int Floor { get; set; }
        public int RoomTypeId { get; set; } //room typeta eklemek gerekir mi ekstra???
        public bool? HasBalcony { get; set; }   // null => RoomType default
        public bool? HasMinibar { get; set; }
        // CheckIn ve CheckOut kaldırıldı - bunlar Reservation'da olmalı
        //public DateTime CheckIn { get; set; }
        //public DateTime CheckOut { get; set; }
        public List<Reservation> Reservations { get; set; } = new();    // Navigation property for related reservations

        public RoomType RoomType { get; set; } = default!; // Navigation property for related room type
        
    }
}
