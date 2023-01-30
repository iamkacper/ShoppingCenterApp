using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Models.ViewModels;
using ShoppingCenter.Services.ItemServices;
using System.Data;

namespace ShoppingCenter.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddItemToShop()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddItemToShop(ItemVm itemVm,int id)
        {
            _service.Create(itemVm,id);
            return RedirectToAction("Index","Shop");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var item = _service.GetById(id);
            if(item == null)
            {
                return RedirectToAction("Index", "Shop");
            }
            return View(item);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(ItemVm itemVm, int id)
        {
            _service.Update(itemVm,id);
            return RedirectToAction("Index", "Shop");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index", "Shop");
        }
        public IActionResult Buy()
        {
            return View();
        }
    }
}
