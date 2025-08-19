using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    // 10) Vardiya Şablonu
    public class ShiftTemplate
    {
     
        public string Name { get; set; } = default!; // 08-16 gibi
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
