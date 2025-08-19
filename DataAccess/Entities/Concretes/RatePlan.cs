using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 5) Fiyat Listesi (Sezonluk)
    public class RatePlan
    {
       
        public int RoomTypeId { get; set; }
        public int BoardTypeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal BasePricePerNight { get; set; }
        public string Currency { get; set; } = "TRY";
    }
}
