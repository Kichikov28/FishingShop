namespace FishingShop.Services
{
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class ProductService
    {
        private AppDbContext context;
        public string AddProduct(string name, decimal price)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid {nameof(name)}!");
                isValid = false;
            }
            if (price < 0)
            {
                message.AppendLine($"Invalid {nameof(price)}!");
                isValid = false;
            }
            if (isValid)
            {
                Product product = new Product()
                {
                    Name = name,
                    Price = price
                };
                using (context = new AppDbContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    message.AppendLine($"Product {name} which costs {price} leva is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public Product GetProductById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Products.Find(id);
            }
        }
        public Product GetProductByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid Product name!");
            }
            using (context = new AppDbContext())
            {
                Product product = context.Products.FirstOrDefault(x => x.Name == name);
                return product;
            }
        }
        public string UpdateProductPrice(int id, decimal newPrice)
        {
            using (context = new AppDbContext())
            {
                Product product = context.Products.Find(id);
                if (product == null)
                {
                    return $"{nameof(Product)} not found!";
                }
                if (newPrice < 0)
                {
                    return $"Invalid new Price!";
                }
                product.Price = newPrice;
                context.Products.Update(product);
                context.SaveChanges();
                return $"{nameof(Product)} {product.Name} has new price: {newPrice}";
            }
        }
        public string DeleteProductById(int id)
        {
            using (context = new AppDbContext())
            {
                Product product = context.Products.Find(id);
                if (product == null) { return $"{nameof(Product)} not found!"; }
                context.Products.Remove(product);
                context.SaveChanges();
                return $"{nameof(Product)} {product.Name} was deleted!";
            }
        }
        public string GetAllProductsInfo(int page = 1, int count = 10)
        {
            StringBuilder message = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-20} | {"Price",-5}|";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Product> products = context.Products
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
                message.AppendLine(firstRow);
                message.AppendLine(line);
                foreach (var p in products)
                {
                    string info = $"| {p.Id,-4} | {p.Name,-20} | {p.Price,-5}|";
                    message.AppendLine(info);
                    message.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Products.Count() / (decimal)count);
                message.AppendLine($"Page: {page} / {pageCount}");
            }

            return message.ToString().TrimEnd();
        }
        public int GetProductsPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Products.Count() / (double)count);
            }
        }
        public List<string> GetProductsBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Products
                    .Skip((page - 1) * count)
                    .Take(count)
                    .Select(x => $"{x.Id} - {x.Name} has price: {x.Price}")
                    .ToList();
            }
            return list;
        }
    }

}
