using ComputerShop.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Concrete
{
    public class ComputerShopDbContext : DbContext
    {
        public ComputerShopDbContext() : base()
        {

        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<ProductState> ProductStates { get; set; }
        public DbSet<ShippingInfo> ShippingInfos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
