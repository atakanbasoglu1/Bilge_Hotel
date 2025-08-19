using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 12) Erken Rezervasyon İndirimi
    public class EarlyBookingRule
    {
       
        public int MinDaysBeforeCheckIn { get; set; } // 30, 90...
        public int? BoardTypeId { get; set; }        // null => tüm paketler
        public decimal DiscountPercent { get; set; } // 18, 16, 23...
    }
}
