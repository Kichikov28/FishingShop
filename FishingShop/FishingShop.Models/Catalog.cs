namespace FishingShop.Models
{using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Catalog
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public int FishingShopId { get; set; }
        public virtual Shop  Shop { get; set; }

        public virtual ICollection<CatalogProduct> CatalogProducts { get; set; } = new List<CatalogProduct>();
    }
}
