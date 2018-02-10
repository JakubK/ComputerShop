using System;
using System.Collections.Generic;
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

        [ForeignKey("Product")]
        public uint ProductID { get; set; }
        public virtual Product Product { get; set; }

        public uint ProductQuantity { get; set; }

        [ForeignKey("Order")]
        public uint OrderID { get; set; }
        public Order Order { get; set; }
        #endregion
    }
}
