using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class AddInventoryViewModel
    {
        public Inventory ınventory { get; set; }
        
        public string InventoryName { get; set; }

        public List<WareHouse> wareHouse { get;set; }
    }
}
