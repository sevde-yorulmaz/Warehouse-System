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
    public class WareHouseManager : IWareHouseService
    {
        private IWareHouseDal _WareHouseDal;

        public WareHouseManager(IWareHouseDal wareHouseDal)
        {
            _WareHouseDal = wareHouseDal;
        }

        public void Add(WareHouse entity)
        {
            _WareHouseDal.Add(entity);
        }

        public void Delete(WareHouse entity)
        {
            _WareHouseDal.Delete(entity);
        }

        public List<WareHouse> GetAll()
        {
            return _WareHouseDal.GetAll();
        }

        public WareHouse GetById(int id)
        {
            return _WareHouseDal.GetById(id);
        }

        public void Update(WareHouse entity)
        {
            _WareHouseDal.Update(entity);
        }
    }
}
