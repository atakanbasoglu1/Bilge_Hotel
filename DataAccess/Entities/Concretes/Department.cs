using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; } 
        public string? Description { get; set; } // Açıklama alanı isteğe bağlı
        public List<Staff> Staffs { get; set; }  // İlişkili personel listesi

    }
}
