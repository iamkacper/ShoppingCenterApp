using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Models;
using ShoppingCenter.Services.ShopServices;

namespace ShoppingCenter.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _service;

        public ShopController(IShopService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var shops = _service.GetAll();
            return View(shops);
        }
        public IActionResult Edit(string id)
        {
            var shop = _service.GetById(id);
            return View(shop);
        }

        [HttpPost]
        public IActionResult EditShop(string id, [Bind("ShopId,ShopName,Description,Level")] Shop shop)
        {
            _service.Edit(shop, id);
            return RedirectToAction("Index");
        }

        public IActionResult Items(int id)
        {
            var items = _service.GetItems(id);
            return View(items);
        }

    }
}
