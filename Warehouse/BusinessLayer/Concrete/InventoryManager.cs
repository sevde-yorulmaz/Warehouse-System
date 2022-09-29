using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class InventoryManager:IInventoryService
    {
        private IInventoryDal _ınventoryDal;

        public InventoryManager(IInventoryDal ınventoryDal)
        {
            _ınventoryDal = ınventoryDal;
        }

        public void Add(Inventory entity)
        {
            _ınventoryDal.Add(entity);
        }

        public void Delete(Inventory entity)
        {
            _ınventoryDal.Delete(entity);
        }

        public List<Inventory> GetAll()
        {
            return _ınventoryDal.GetAll();
        }

        public Inventory GetById(int id)
        {
            return _ınventoryDal.GetById(id);
        }

        public void Update(Inventory entity)
        {

            _ınventoryDal.Update(entity);
        }
    }
}
