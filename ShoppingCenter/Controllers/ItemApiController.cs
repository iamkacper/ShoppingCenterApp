﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShoppingCenter.Models.ViewModels;
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

        [HttpDelete] 
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.GetById(id);
            if (result != null)
            {
                _service.Delete(id);
                return Ok();
            }
            return NotFound();
        }

        [HttpPost] // poprawić
        [Route("{id}")]
        public IActionResult Create([FromRoute] int id, [FromBody] ItemVm itemVm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _service.Create(itemVm, id);
            return Created($"/api/item/{itemVm.ItemId}", itemVm);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] ItemVm itemVm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var isUpdated = _service.Update(itemVm, id);

            if (!isUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

    }
}
