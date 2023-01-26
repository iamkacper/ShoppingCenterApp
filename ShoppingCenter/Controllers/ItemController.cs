using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Models.ViewModels;
using ShoppingCenter.Services.ItemServices;

namespace ShoppingCenter.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        public IActionResult AddItemToShop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItemToShop(ItemVm itemVm,int id)
        {
            _service.Create(itemVm,id);
            return RedirectToAction("Index","Shop");
        }
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
        public IActionResult Edit(ItemVm itemVm, int id)
        {
            _service.Update(itemVm,id);
            return RedirectToAction("Index", "Shop");
        }

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
