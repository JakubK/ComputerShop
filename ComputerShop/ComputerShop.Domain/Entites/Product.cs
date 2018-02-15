using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    [Table("Products")]
    public class Product
    {
        #region Columns
        [Key,ForeignKey("OrderDetails")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,MinLength(3),MaxLength(30)]
        public string Name { get; set; }
        [Required,DefaultValue(0)]
        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public uint CategoryID { get; set; }
        public virtual Category Category { get; set; }
        #endregion

        public virtual List<ProductRating> ProductRatings { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<CartDetail> CartDetails { get; set; }
        public virtual List<ProductPhoto> ProductPhotos { get; set; }
    }
}
