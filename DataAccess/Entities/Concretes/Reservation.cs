using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public enum ReservationSource { Web = 1, Reception = 2 }
    public enum ReservationStatus { Pending, Confirmed, CheckedIn, CheckedOut, Cancelled }

    public class Reservation:BaseEntity
    {
       
        public int GuestId { get; set; }
        public int? RoomId { get; set; }          // istersen sonradan oda atarsın
        public int BoardTypeId { get; set; }
        public DateTime CheckIn { get; set; }     // giriş tarihi (14:00 varsayılabilir)
        public DateTime CheckOut { get; set; }    // çıkış tarihi (10:00 varsayılabilir)
        public ReservationSource Source { get; set; }
        public ReservationStatus Status { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Room Room { get; set; } = default!; // Navigation property for related room
        public Guest Guest { get; set; } = default!; // Navigation property for related guest
        public List<Charge> Charges { get; set; } = new();  // Navigation property for related charges
        public BoardType BoardType { get; set; } = default!; // Navigation property for related board type
    }
}
