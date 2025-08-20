using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    //  Vardiya Şablonu
    public class ShiftTemplate:BaseEntity
    {
     
        public string Name { get; set; } = default!; // 08-16 gibi
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<ShiftAssignment> ShiftAssignments { get; set; }  // İlişkili vardiya atamaları
    }
}
