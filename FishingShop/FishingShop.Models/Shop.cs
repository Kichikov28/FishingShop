using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FishingShop.Models
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public string Type { get; set; }

        public double Rating { get; set; }

        public DateTime EstablishedOn { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Catalog> Catalogs { get; set; }=new List<Catalog>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
