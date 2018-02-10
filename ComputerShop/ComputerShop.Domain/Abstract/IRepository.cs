using ComputerShop.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Abstract
{
    public interface IRepository
    {
        IEnumerable<Cart> Carts { get; }
        IEnumerable<CartDetail> CartDetails { get; }
        IEnumerable<Category> Categories { get; }
        IEnumerable<Order> Orders { get; }
        IEnumerable<OrderDetail> OrderDetails { get; }
        IEnumerable<Payment> Payments { get; }
        IEnumerable<Product> Products { get; }
        IEnumerable<ProductRating> ProductRatings { get; }
        IEnumerable<ProductState> ProductStates { get; }
        IEnumerable<ShippingInfo> ShippingInfos { get; }
        IEnumerable<User> Users { get; }
    }
}
