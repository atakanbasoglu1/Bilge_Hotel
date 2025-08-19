using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{

    // 11) Vardiya Ataması (Puantaj)
    public class ShiftAssignment
    {
        
        public int StaffId { get; set; }
        public DateTime Date { get; set; }
        public int ShiftTemplateId { get; set; }
        public bool IsOffDay { get; set; }
        public bool IsOvertime { get; set; }
        public double OvertimeHours { get; set; }
    }

}
