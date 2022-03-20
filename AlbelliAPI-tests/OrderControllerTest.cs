using AlbelliAPI.Controllers;
using AlbelliAPI.Data;
using AlbelliAPI.DTOs;
using AlbelliAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlbelliAPI_tests
{
    public class OrderControllerTest
    {
   
        [Fact]
        public void GetById_WhenIdIsProvided_FetchesOrderInformataion()
        {

            // Arrange

            #region This region can be moved to a  new class
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var _context = new DataContext(options);
            _context.Database.EnsureCreated();
            SeedDb(_context);
            #endregion

            int testOrderID = 3;
            var _OrderController = new OrderController(_context); 


            // Act
            var result = _OrderController.Get(testOrderID);
            // Assert
            Assert.NotNull(result);
            var objectResult = Assert.IsType<OkObjectResult>(result.Result);
            var products = Assert.IsAssignableFrom<OrderRetrievalDto>(objectResult.Value);
            Assert.NotNull(products);
            Assert.NotNull(products.ProdcutsDtos);
            Assert.Equal(3, products.ProdcutsDtos.Count);
            Assert.Equal("133mm", products.RequiredBinWidth);
        }


        private void SeedDb(DataContext _context)
        {
            var newOrder1 = new OrderInfomation()
            {
                Id = 2,
            };
            _context.OrderInfomation.Add(newOrder1);

            var newOrder1_Prodcut_1 = new Order_Product
            {
                OrderId = 2,
                ProductId = 1, //photobook
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder1_Prodcut_1);

            var newOrder1_Prodcut_2 = new Order_Product
            {
                OrderId = 2,
                ProductId = 2,//calendar
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder1_Prodcut_2);

            var newOrder1_Prodcut_3 = new Order_Product
            {
                OrderId = 2,
                ProductId = 3,// canvas
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder1_Prodcut_3);

            var newOrder1_Prodcut_4 = new Order_Product
            {
                OrderId = 2,
                ProductId = 4, //cards
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder1_Prodcut_4);

            var newOrder1_Prodcut_5 = new Order_Product
            {
                OrderId = 2,
                ProductId = 5, // mug
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder1_Prodcut_5);

            // for order number 2 => 1 each from all the product types , therefore the bindedwidth should be 19 + 10 + 16 + 4.7 + 94 == 143.7

            ////////////////////////////////// new order 3 
            var newOrder2 = new OrderInfomation()
            {
                Id = 3,
            };
            _context.OrderInfomation.Add(newOrder2);

            var newOrder2_Prodcut_1 = new Order_Product
            {
                OrderId = 3,
                ProductId = 1, //photobook
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder2_Prodcut_1);

            var newOrder2_Prodcut_2 = new Order_Product
            {
                OrderId = 3,
                ProductId = 2,//calendar
                Quantity = 2
            };
            _context.Order_Products.Add(newOrder2_Prodcut_2);


            var newOrder2_Prodcut_5 = new Order_Product
            {
                OrderId = 3,
                ProductId = 5, // mug
                Quantity = 1
            };
            _context.Order_Products.Add(newOrder2_Prodcut_5);

            // for order number 3 => 1 photobook , 2 calendars 12 mug therefore the bindedwidth should be 19 + 10*2 +  94 == 133


            _context.SaveChanges();

        }
    }
}
