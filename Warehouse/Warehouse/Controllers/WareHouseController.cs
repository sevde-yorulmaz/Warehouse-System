using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class WareHouseController : Controller
    {
        WareHouseManager houseManager = new WareHouseManager(new EfWareHouseDal());
        InventoryManager ınventoryManager = new InventoryManager(new EfInventoryDal());
        public IActionResult Index()
        { 
            var warehousevalue = houseManager.GetAll().Where(x=>x.Status==true);//durumu true olanlar listelenecek
            var inventoryvalue = ınventoryManager.GetAll().Where(x => x.Status== true);
            GetInventory get = new GetInventory()
            {
                wareHouses = warehousevalue.ToList(),
                ınventories=inventoryvalue.ToList()
            };
            return View(get);
        }

        [HttpGet]

        public IActionResult AddWareHouse()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddWareHouse(WareHouse warehouse)
        {
            warehouse.Status = true;
            houseManager.Add(warehouse);
            return RedirectToAction("Index","WareHouse");
        }

        [HttpGet]

        public IActionResult EditWareHouse(int id)
        {
            WareHouse wareHouse = houseManager.GetById(id);//düzenlemek istediğimiz depoyu buluyoruz
            
            return View(wareHouse);
        }

        [HttpPost]

        public IActionResult EditWareHouse(WareHouse wareHouse)
        {
            wareHouse.Status = true;
            houseManager.Update(wareHouse);
            return RedirectToAction("Index","WareHouse");
        }

        public IActionResult DeleteWareHouse(int id)
        {
            WareHouse wareHouse = houseManager.GetById(id);
            wareHouse.Status = false;
            houseManager.Update(wareHouse);
            return RedirectToAction("Index", "WareHouse");
        }
    }
}
