using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    // Maaş hesaplama için
    public class SalaryCalculation : BaseEntity
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; } = default!;
        public DateTime Month { get; set; }
        public decimal TotalHours { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
