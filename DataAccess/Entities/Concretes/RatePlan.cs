using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    // Fiyat Listesi (Sezonluk)
    public class RatePlan:BaseEntity
    {
       
        public int RoomTypeId { get; set; }
        public int BoardTypeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal BasePricePerNight { get; set; }
        public string Currency { get; set; } = "TRY";

        public BoardType BoardType { get; set; } // Navigation property for related board type
    }
}
