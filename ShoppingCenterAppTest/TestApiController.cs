using System;
using ShoppingCenter.Controllers;
using ShoppingCenter.Services;
using ShoppingCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using ShoppingCenter.Services.ShopServices;
using Moq;
using ShoppingCenter.Services.ItemServices;
using ShoppingCenter.Models.ViewModels;

namespace ShoppingCenterAppTest
{
    public class TestApiController
    {
        private readonly Mock<IItemService> _service;
        private readonly ItemApiController _controller;
        public TestApiController()
        {
            _service = new Mock<IItemService>();
            _controller = new ItemApiController(_service.Object);
        }

        [Fact]
        public void GetById_WhenCalled_ShouldReturnsOk()
        {
            //arrange
            int id = 10;

            var item = new Item()
            {
                ItemId = id,
                NameItem = "test",
                ColorItem = "test",
                SizeItem = "test",
                PriceItem = 25,
                Url = "test",
                DescriptionItem = "desc"
            };

            _service.Setup(x => x.GetById(It.Is<int>(x => x == id)))
                .Returns(item);

            var response = (OkObjectResult)_controller.GetById(id);

            Assert.Equal(200, response.StatusCode);

        }

        [Fact]
        public void Delete_WhenCalled_ShouldReturns_NotFound()
        {

            _service.Setup(x => x.Delete(It.IsAny<int>()))
                .Returns(true);

            var response = (NotFoundResult)_controller.Delete(It.IsAny<int>());

            Assert.Equal(404, response.StatusCode);

        }

        [Fact]
        public void Create_WhenCalled_ShouldReturnsCreated()
        {
            int id = 10;

            var item = new ItemVm()
            {
                ItemId = id,
                NameItem = "test",
                ColorItem = "test",
                SizeItem = "test",
                PriceItem = 25,
                Url = "test",
                DescriptionItem = "desc"
            };

            var response = (CreatedResult)_controller.Create(id, item);

            Assert.Equal(201, response.StatusCode);

            var valueObject = Assert.IsAssignableFrom<ItemVm>(response.Value);

            Assert.NotNull(response.Location);

            _service.Verify(x => x.Create(item, id), Times.Once);
        }

        [Fact]
        public void Update_WhenCalled_ShouldReturnsOK()
        {
            int id = 10;

            var item = new ItemVm()
            {
                ItemId = id,
                NameItem = "test",
                ColorItem = "test",
                SizeItem = "test",
                PriceItem = 25,
                Url = "test",
                DescriptionItem = "desc"
            };

            _service.Setup(x => x.Update(item, id))
                .Returns(true);

            var response = (OkResult)_controller.Update(id, item);

            Assert.Equal(200, response.StatusCode);

            _service.Verify(x => x.Update(item, id), Times.Once);

        }

    }
}