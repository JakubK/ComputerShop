using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class CartDetail
    {
        #region Columns
        [Key]
        public int ID { get; set; }

        [ForeignKey("Cart"),Required]
        public int CartID { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Product"),Required]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
        #endregion
    }
}
