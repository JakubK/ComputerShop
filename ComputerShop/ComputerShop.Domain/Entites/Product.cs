using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class Product
    {
        #region Columns
        [Key,ForeignKey("OrderDetail")]
        public uint ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public uint CategoryID { get; set; }
        public virtual Category Category { get; set; }
        #endregion

        public virtual List<ProductRating> ProductRatings { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<CartDetail> CartDetails { get; set; }
    }
}
