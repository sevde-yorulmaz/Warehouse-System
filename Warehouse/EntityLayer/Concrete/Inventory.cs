using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Inventory:BaseEntity
    {
        public string inventoryName { get; set; }

        [ForeignKey("WarehouseId")]

        public int WarehouseId { get; set; }

        public WareHouse Warehouse { get; set; }

        public bool Status { get; set; }
    }
}
