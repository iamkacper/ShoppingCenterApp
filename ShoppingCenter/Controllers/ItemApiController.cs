using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Services.ItemServices;

namespace ShoppingCenter.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemApiController : ControllerBase
    {
        private readonly IItemService _service;

        public ItemApiController(IItemService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return BadRequest();
            }
            return Ok(item);
        }
    }
}
