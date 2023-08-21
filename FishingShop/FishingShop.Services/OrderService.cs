namespace FishingShop.Services
{
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class OrderService
    {
        private AppDbContext context;
        public string CreateOrder(int shoptId, int clietntId, List<int> productId)
        {
            using (context = new AppDbContext())
            {
                Order order = new Order()
                {
                    ShopId = shoptId,
                    ClientId = clietntId
                };
                foreach (var item in productId)
                {
                    order.OrderProducts.Add(new OrderProduct { ProductId = item, Quantity = 1 });
                }
                context.Orders.Add(order);
                context.SaveChanges();
                return $"Your order is on your way.";
            }
        }
        public decimal GetProductPrice(int productId)
        {
            var product = context.Products.FirstOrDefault(i => i.Id == productId);

            if (product == null)
            {
                throw new ArgumentException($"Item with ID {productId} not found.");
            }

            return product.Price;
        }

        public List<string> GetProducts()
        {
            List<string> productsInfo;
            using (context = new AppDbContext())
            {
                productsInfo = this.context.Products
                    .OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.Name} - {x.Price}")
                     .ToList();
            }
            return productsInfo;

        }
    }
}
