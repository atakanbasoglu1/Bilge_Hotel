using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{

    //  Vardiya Ataması (Puantaj)
    public class ShiftAssignment:BaseEntity
    {
        
        public int StaffId { get; set; }
        public Staff Staff { get; set; }  // Staff sınıfından bir Staff nesnesi ile ilişkilendirilmiş vardiya atamasını temsil eder.

        

        public int ShiftTemplateId { get; set; }
        public ShiftTemplate ShiftTemplate { get; set; }  // ShiftTemplate sınıfından bir ShiftTemplate nesnesi ile ilişkilendirilmiş vardiya atamasını temsil eder.
        public DateTime IsOffDay { get; set; }
        public DateTime IsOvertime { get; set; }
        public double OvertimeHours { get; set; }


    }

}
