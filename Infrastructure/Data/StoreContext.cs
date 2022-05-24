using Core.Identities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeAddresses>()
                .HasKey(ea => new { ea.EmployeeID, ea.CountryID });
            modelBuilder.Entity<ProductPromotion>()
                .HasKey(sc => new { sc.ProductId, sc.PromotionId });
            modelBuilder.Entity<UserAddress>()
                .HasKey(ua => new { ua.UserId, ua.AddressId });            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EmployeeAddresses> EmployeeAddresses { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<ApplicationUser<Guid>> Users { get; set; }
        public DbSet<ApplicationRole<Guid>> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UOM> UOMs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ProductPromotion> ProductPromotions { get; set; }
    }
}
