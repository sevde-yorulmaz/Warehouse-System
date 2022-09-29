using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class InventoryController : Controller
    {
        InventoryManager ınventoryManager = new InventoryManager(new EfInventoryDal());
        WareHouseManager houseManager = new WareHouseManager(new EfWareHouseDal());
        public IActionResult Index()
        {
            var ınventoryValue = ınventoryManager.GetAll().Where(x=>x.Status==true);
            var wareHouseValue = houseManager.GetAll().Where(x => x.Status == true);
            
            GetInventory get = new GetInventory()
            {
                ınventories = ınventoryValue.ToList(),
                wareHouses=wareHouseValue.ToList()
            };
            return View(get);
        }

        [HttpGet]
        public IActionResult AddInventory()
        {
            AddInventoryViewModel addInventory = new AddInventoryViewModel()
            {
                wareHouse=houseManager.GetAll()
            };
            return View(addInventory);
        }

        [HttpPost]
        public IActionResult AddInventory(AddInventoryViewModel addInventory)
        {
            var wareHouseValue = houseManager.GetById(addInventory.ınventory.WarehouseId);

            if (ModelState.IsValid)
            {
                addInventory.ınventory.inventoryName = addInventory.InventoryName;
                addInventory.ınventory.Status = true;
                Inventory ınventory = new Inventory()
                { inventoryName = addInventory.ınventory.inventoryName,
                    Warehouse = wareHouseValue,
                    Status= addInventory.ınventory.Status
                };
                
                if (ınventory != null)
                {
                    ınventoryManager.Add(addInventory.ınventory);
                    return RedirectToAction("Index", "Inventory");
                }
            }
            return View(addInventory);
            
        }

        [HttpGet]
        public IActionResult EditInventory(int id)
        {
            var whouse = houseManager.GetAll().Where(x => x.Status == true);
            var value = new EditInventoryViewModel
            { 
             Inventory= ınventoryManager.GetById(id),//düzenlenecek envateri seçtik
             warehouses=whouse.ToList()//depo listesini getirecek

             };
            
            return View(value);
        }

        [HttpPost]
        public IActionResult EditInventory(EditInventoryViewModel editınventory)
        {
            var wareHouse = houseManager.GetById(editınventory.Inventory.WarehouseId);//seçili depoyu buldu
            var inventory = ınventoryManager.GetAll().Where(x => x.Id == editınventory.Inventory.Id).FirstOrDefault();//seçtiğimiz envanteri bulduk
            var name = editınventory.inventoryName;
            editınventory.Inventory.inventoryName = name;
            if (ModelState.IsValid)
            {
                inventory.inventoryName = editınventory.Inventory.inventoryName;//ad düzenleme
                inventory.Warehouse = wareHouse;//depoyu değiştirebiliriz
                inventory.WarehouseId = editınventory.Inventory.WarehouseId;
                ınventoryManager.Update(inventory);
            }

            return RedirectToAction("Index","Inventory");
        }

        public IActionResult DeleteInventory(int id)
        {
            Inventory ınventory = ınventoryManager.GetById(id);
            //seçtiğimiz envanter  id sini alacak
            ///ya da envanter durumu false çekilerek güncelleme yapabiliriz bu şekilde database kısmında bilgi eksikliğimiz olmaz istediğimizde durumunu true ya çekerek envanter ile ilgili işlem yapabiliriz.
            ınventory.Status = false;
            ınventoryManager.Update(ınventory);
            return RedirectToAction("Index","Inventory");
        }
    }
}
