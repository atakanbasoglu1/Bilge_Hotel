using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Abstract
{
    public abstract class BaseEntity : IEntity<Guid>
    {

        protected BaseEntity()
        {
            Status = DataStatus.Active;
            MasterID = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            CreatedComputerName = System.Environment.MachineName;
            //todo: IP adresi için bir extension metot oluşturulacak.
            CreatedIpAddress = "192.168.1.1";

        }


        public Guid MasterID { get; set; }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
        public DataStatus Status { get; set; }
    }
}
