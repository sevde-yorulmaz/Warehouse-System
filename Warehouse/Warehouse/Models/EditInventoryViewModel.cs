using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class EditInventoryViewModel
    {
        public List<WareHouse> warehouses { get; set; }
        public Inventory Inventory { get; set; }
        public string inventoryName { get; set; }

    }
}
