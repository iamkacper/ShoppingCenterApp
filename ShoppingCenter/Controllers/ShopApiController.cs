using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShoppingCenter.Models;
using ShoppingCenter.Models.ViewModels;
using ShoppingCenter.Services.ItemServices;
using ShoppingCenter.Services.ShopServices;

namespace ShoppingCenter.Controllers
{
    [Route("api/shop")]
    [ApiController]
    public class ShopApiController : ControllerBase
    {
        private readonly IShopService _service;

        public ShopApiController(IShopService service)
        {
            _service = service;
        }

        // GET: api/<ShopApiController>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(string id)
        {
            var shop = _service.GetById(id);
            if (shop == null)
            {
                return BadRequest();
            }
            return Ok(shop);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Create( [FromBody] ShopVm shop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _service.Create(shop);
            return Created($"/api/shop/{shop.ShopId}", shop);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit([FromRoute] string id, [FromBody] Shop shop)
        {
            var found = _service.GetById(id);
            if (found == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _service.Edit(shop, id);
                return Ok();
            }
            return BadRequest();
        }

        //[HttpDelete]
        //[Route("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var result = _service.GetById(id);
        //    if (result != null)
        //    {
        //        _service.Delete(id);
        //        return Ok();
        //    }
        //    return NotFound();
    }
}

