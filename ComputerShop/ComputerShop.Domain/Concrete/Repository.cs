using ComputerShop.Domain.Abstract;
using ComputerShop.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Concrete
{
    public class Repository : IRepository
    {
        private ComputerShopDbContext dbContext = new ComputerShopDbContext();

        public IEnumerable<Cart> Carts
        {
            get { return dbContext.Carts; }
        }

        public IEnumerable<CartDetail> CartDetails
        {
            get { return dbContext.CartDetails; }
        }

        public IEnumerable<Category> Categories
        {
            get { return dbContext.Categories; }
        }

        public IEnumerable<Order> Orders
        {
            get { return dbContext.Orders; }
        }

        public IEnumerable<OrderDetail> OrderDetails
        {
            get { return dbContext.OrderDetails; }
        }

        public IEnumerable<Payment> Payments
        {
            get { return dbContext.Payments; }
        }

        public IEnumerable<Product> Products
        {
            get { return dbContext.Products; }
        }

        public IEnumerable<ProductPhoto> ProductPhotos
        {
            get { return dbContext.ProductPhotos; }
        }

        public IEnumerable<ProductRating> ProductRatings
        {
            get { return dbContext.ProductRatings; }
        }

        public IEnumerable<ProductState> ProductStates
        {
            get { return dbContext.ProductStates; }
        }

        public IEnumerable<ShippingInfo> ShippingInfos
        {
            get { return dbContext.ShippingInfos; }
        }

        public IEnumerable<User> Users
        {
            get { return dbContext.Users; }
        }
    }
}
