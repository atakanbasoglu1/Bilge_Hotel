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
        
        public int ShiftTemplateId { get; set; }
        public DateTime IsOffDay { get; set; }
        public DateTime IsOvertime { get; set; }
        public double OvertimeHours { get; set; }
    }

}
