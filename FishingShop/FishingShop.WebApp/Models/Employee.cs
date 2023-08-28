namespace FishingShop.WebApp.Models
{
    using FishingShop.Models;
    using System.ComponentModel.DataAnnotations;
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string ContactPhone { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
