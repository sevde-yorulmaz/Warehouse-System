﻿using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WareHouse:BaseEntity
    {
        public string wareHouseName { get; set; }

        public List<Inventory> Inventory { get; set; }
        public bool Status { get; set; }


    }
}
