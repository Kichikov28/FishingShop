namespace FishingShop.Data
{
    using FishingShop.Models;
    using Microsoft.EntityFrameworkCore;
    using Castle.Core.Resource;

    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Server=DESKTOP-40P9254\MSSQLSERVER01; Initial Catalog=FishingShopEf; Integrated Security=true; Trusted_Connection =true";
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<CatalogProduct> CatalogProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CatalogProduct>(option =>
            {
                option.HasKey(x => new { x.ProductId, x.CatalogId });
            });
            modelBuilder.Entity<Shop>(option =>
            {
                option.Property(x => x.Name)
                    .IsRequired();

                option.Property(x => x.Location)
                    .IsRequired();
            });
            modelBuilder.Entity<Client>(option =>
            {
                option.Property(x => x.FirstName)
                   .IsRequired();
                option.Property(x => x.LastName)
                   .IsRequired();
                option.Property(x => x.PhoneNumber)
                .IsRequired();
                option.Property(x => x.Adress)
                .IsRequired();
            });
            modelBuilder.Entity<Catalog>(option =>
            {
                option.Property(x => x.Type)
                    .IsRequired();

                option.HasOne(x => x.Shop)
                    .WithMany(x => x.Catalogs)
                    .HasForeignKey(x => x.FishingShopId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Product>(option =>
            {
                option.Property(x => x.Name)
                .IsRequired();
            });
            modelBuilder.Entity<Employee>(option =>
            {
                option.Property(x => x.FirstName)
                   .IsRequired();
                option.Property(x => x.LastName)
                   .IsRequired();
                option.Property(x => x.Age)
                .IsRequired();
                option.Property(x => x.Position)
                .IsRequired();
            });
        }
    }

}
