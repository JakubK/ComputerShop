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
    public class OrderDetail
    {
        #region Columns
        [Key]
        public int ID { get; set; }

        [ForeignKey("Product"), Required]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required, DefaultValue(0)]
        public int ProductQuantity { get; set; }

        [ForeignKey("Order"), Required]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        #endregion
    }
}
