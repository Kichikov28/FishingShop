using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FishingShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }

    }
}
