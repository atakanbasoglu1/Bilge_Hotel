using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 9) Personel
    public class Staff
    {
      
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Department { get; set; } = default!; // Reception, Housekeeping...
        public string Role { get; set; } = default!;
        public decimal? HourlyWage { get; set; }     // saatlik ücretliler
        public decimal? MonthlySalary { get; set; }  // maaşlılar
    }
}
