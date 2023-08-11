namespace FishingShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;

    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        
        public int ShopId { get; set; }
        [NotMapped]
        public decimal TotalAmount { get => OrderProducts.Sum(x => x.Product.Id);}

        public int CustomerId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
