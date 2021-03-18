using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Services.ItemService;
using Inventory.Data;

namespace Inventory.UI.Controllers
{
    public class ItemsController : Controller
    {

        // InventoryHelper _inventoryHelper = new InventoryHelper();
        private readonly IItemRepository _itemRepository;
        List<Item> items;
        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(Item item)
        {
            if (item != null) { 
            _itemRepository.AddItem(item);
            return RedirectToAction("index");
            }
            return View(item);
        }
        public IActionResult index()
        {
            items = new List<Item>();
            items = _itemRepository.GetItems().ToList();
            long totalItem = 0;
            double itWorth = 0;
            foreach (var item in items)
            {
                totalItem += item.Quantity;
                itWorth += item.Quantity * item.Price;
            }
            ViewBag.TotalItem = totalItem;
            ViewBag.totalPrice = itWorth;
            return View(items);
        }

        public IActionResult Details(Guid id)
        {
            var item = _itemRepository.GetItem(id);
            if (item == null) return NotFound("Item Not found");
            return View(item);

        }

        public IActionResult Delete(Guid id)
        {
            if (id != null) _itemRepository.DeleteItem(id);
            return RedirectToAction("index");
        }
    }
}