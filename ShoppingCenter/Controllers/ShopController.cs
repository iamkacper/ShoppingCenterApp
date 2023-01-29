using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;
using ShoppingCenter.Services.ShopServices;
using System.Data;

namespace ShoppingCenter.Controllers
{
    [Authorize]
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
        public IActionResult EditShop(string id, [Bind("ShopId,Url,ShopName,Description,Email,Level")] Shop shop)
        {
            _service.Edit(shop, id);
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateShop(ShopVm shop)
        {
            _service.Create(shop);
            return RedirectToAction("Index");
        }

        public IActionResult Items(int id)
        {
            var items = _service.GetItems(id);
            return View(items);
        }

        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
