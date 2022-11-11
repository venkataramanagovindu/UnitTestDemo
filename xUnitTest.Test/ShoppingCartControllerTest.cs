namespace xUnitTest.Test
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UnitTestDemo.Controllers;
    using UnitTestDemo.IServices;
    using UnitTestDemo.Models;

    public class ShoppingCartControllerTest
    {
        private readonly ShoppingCartController _controller;
        private readonly IShoppingCartService _service;

        public ShoppingCartControllerTest()
        {
            _service = new ShoppingCartServiceFake();
            _controller = new ShoppingCartController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var OkResult = _controller.Get();

            // Assert
            Assert.IsType<OkObjectResult>(OkResult as OkObjectResult);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var OkResult = _controller.Get() as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<ShoppingItem>>(OkResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
