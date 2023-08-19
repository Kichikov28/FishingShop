using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FishingShop.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string ContactPhone { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
