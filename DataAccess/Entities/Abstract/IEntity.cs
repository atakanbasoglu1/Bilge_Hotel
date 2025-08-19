using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Abstract
{
    internal interface IEntity<T>
    {

        public T MasterID { get; set; }
        public int ID { get; set; }

        //CreatedProperties
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }


        //UpdatedProperties
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }

        public DataStatus Status { get; set; }

    }
}
