using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public class BoardType:BaseEntity
    {
        
        public string Code { get; set; } = default!; // FullBoard, AllInclusive
        public string Description { get; set; } = default!;
        public List<RatePlan> RatePlans { get; set; }  // Navigation property for related rate plans

    }
}
