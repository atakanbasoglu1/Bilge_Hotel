using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 7) Ekstra Harcama (Mini bar vb.)
    public class Charge
    {
       
        public int ReservationId { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; } = default!;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "TRY";
    }

}
