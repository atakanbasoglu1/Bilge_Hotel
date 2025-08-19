using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Concretes
{
    public class BoardType
    {
        
        public string Code { get; set; } = default!; // FullBoard, AllInclusive
        public string Description { get; set; } = default!;
    }
}
