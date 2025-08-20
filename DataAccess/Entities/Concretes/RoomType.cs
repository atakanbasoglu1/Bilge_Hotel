using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Abstract;

namespace DataAccess.Entities.Concretes
{
    public class RoomType:BaseEntity
    {
       
        public string Name { get; set; } = default!; // Single, Double...
        public int Capacity { get; set; }
        public bool DefaultHasBalcony { get; set; }
        public bool DefaultHasMinibar { get; set; }

        public List<Room> Rooms { get; set; }  // Navigation property for related rooms
    }
}
