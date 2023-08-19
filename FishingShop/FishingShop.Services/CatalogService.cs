namespace FishingShop.Services
{
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CatalogService
    {
        private AppDbContext context;
        public string CreateCatalog(string type, int fishingshopid)
        {
            using (context = new AppDbContext())
            {
                Catalog catalog = new Catalog()
                {
                    Type = type,
                    FishingShopId = fishingshopid
                };
                context.Catalogs.Add(catalog);
                context.SaveChanges();
                return "Catalog is added!";
            }
        }
        public Catalog GetCatalogByName(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Invalid catalog type!");
            }
            using (context = new AppDbContext())
            {
                Catalog c = context.Catalogs.FirstOrDefault(x => x.Type == type);
                return c;
            }
        }
        public Catalog GetCatalogById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Catalogs.Find(id);
            }
        }
        public string DeleteCatalogById(int id)
        {
            using (context = new AppDbContext())
            {
                Catalog c = this.context.Catalogs.FirstOrDefault(x => x.Id == id);
                if (c == null)
                {
                    return $"{nameof(Catalog)} not found!";
                }
                context.Catalogs.Remove(c);
                context.SaveChanges();
                return $"{nameof(Catalog)} {c.Type} is deleted!";
            }
        }
    }
}
