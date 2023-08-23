namespace FishingShop.Services
{
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class ShopService
    {
        private AppDbContext context;
        public string AddShop(string name, string location, string type, double rating)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid {nameof(name)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(location))
            {
                message.AppendLine($"Invalid {nameof(location)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                message.AppendLine($"Invalid {nameof(type)}!");
                isValid = false;
            }
            if (rating < 2 || rating > 10)
            {
                message.AppendLine($"Invalid {nameof(rating)}!");
                isValid = false;
            }
            if (isValid)
            {
                Shop shop = new Shop()
                {
                    Name = name,
                    Location = location,
                    Type = type,
                    Rating = rating,
                    EstablishedOn = GenerateRandomDate()
                };
                using (context = new AppDbContext())
                {
                    context.Shops.Add(shop);
                    context.SaveChanges();
                    message.AppendLine($"{name} shop in {location} is added!");
                }
            }
            return message.ToString().TrimEnd();

        }

        public Shop GetShopById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Shops.Find(id);
            }
        }
        public string UpdateShopRating(int id, double newRating)
        {
            using (context = new AppDbContext())
            {
                Shop shop = context.Shops.Find(id);
                if (shop == null) { return $"{nameof(Shop)} not found!"; }
                if (newRating < 2 || newRating > 10) { return "Invalid new rating!"; }
                shop.Rating = newRating;
                context.Shops.Update(shop);
                context.SaveChanges();
                return $"{nameof(Shop)} {shop.Name} has new rating: {newRating}";
            }
        }
        public string DeleteShopById(int id)
        {
            using (context = new AppDbContext())
            {
                Shop shop = context.Shops.Find(id);
                if (shop == null) { return $"{nameof(Shop)} not found!"; }
                context.Shops.Remove(shop);
                context.SaveChanges();
                return $"{nameof(Shop)} {shop.Name} in {shop.Location} was deleted!";
            }
        }
        public Shop GetShopByLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Invalid shop location!");
            }
            using (context = new AppDbContext())
            {
                Shop shop = context.Shops.FirstOrDefault(x => x.Location == location);
                return shop;
            }
        }
        public string GetAllShopsInfo(int page = 1, int count = 10)
        {
            StringBuilder message = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-30} | {"Type",-15} | {"Rating",-5} | {"Location",-15}|";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Shop> shops = context.Shops
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
                message.AppendLine(firstRow);
                message.AppendLine(line);
                foreach (var s in shops)
                {
                    string info = $"| {s.Id,-4} | {s.Name,-30} | {s.Type,-15} | {s.Rating,-6} | {s.Location,-15}|";
                    message.AppendLine(info);
                    message.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Shops.Count() / (decimal)count);
                message.AppendLine($"Page: {page} / {pageCount}");
            }
            return message.ToString().TrimEnd();
        }
        public int GetShopsPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Shops.Count() / (double)count);
            }
        }
        private DateTime GenerateRandomDate()
        {
            DateTime startDate = new DateTime(2010, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);

            Random random = new Random();
            int range = (endDate - startDate).Days;
            int randomDays = random.Next(range);

            return startDate.AddDays(randomDays);
        }
        public List<string> GetShopsBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Shops
                    .Skip((page - 1) * count)
                    .Take(count)
                    .Select(x => $"{x.Id} - {x.Name} located in {x.Location} has {x.Rating} rating")
                    .ToList();
            }
            return list;
        }
    }
}

