using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    public enum ReservationSource { Web = 1, Reception = 2 }
    public enum ReservationStatus { Pending, Confirmed, CheckedIn, CheckedOut, Cancelled }

    public class Reservation
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
    }
}
