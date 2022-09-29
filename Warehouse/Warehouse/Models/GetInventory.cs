using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class GetInventory
    {
        public List<Inventory> ınventories { get; set; }
        public List<WareHouse> wareHouses { get; set; }
    }
}
