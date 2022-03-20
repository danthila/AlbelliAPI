using AlbelliAPI.Data;
using AlbelliAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbelliAPI_tests
{
    public class DataContextTestBase : IDisposable
    {
        protected readonly DataContext? _context;

        public DataContextTestBase()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var _context = new DataContext(options);
            _context.Database.EnsureCreated();
            SeedDb(_context);
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
                ProductId = 1,
                Quantity = 5
            };
            _context.Order_Products.Add(newOrder1_Prodcut_1);

            var newOrder2_Prodcut_2 = new Order_Product
            {
                OrderId = 2,
                ProductId = 2,
                Quantity = 2
            };
            _context.Order_Products.Add(newOrder2_Prodcut_2);

            var newOrder3_Prodcut_3 = new Order_Product
            {
                OrderId = 2,
                ProductId = 3,
                Quantity = 3
            };
            _context.Order_Products.Add(newOrder3_Prodcut_3);

            var newOrder4_Prodcut_4 = new Order_Product
            {
                OrderId = 2,
                ProductId = 4,
                Quantity = 4
            };
            _context.Order_Products.Add(newOrder4_Prodcut_4);

            var newOrder5_Prodcut_5 = new Order_Product
            {
                OrderId = 2,
                ProductId = 5,
                Quantity = 6
            };
            _context.Order_Products.Add(newOrder5_Prodcut_5);


            _context.SaveChanges();

        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
