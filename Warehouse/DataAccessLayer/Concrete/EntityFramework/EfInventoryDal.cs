using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfInventoryDal:GenericRepository<Inventory,DataContext>,IInventoryDal
    {
    }
}
