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
        public uint ID { get; set; }

        [ForeignKey("Cart")]
        public uint CartID { get; set; }
        public virtual Cart Cart { get; set; }

        [ForeignKey("Product")]
        public uint ProductID { get; set; }
        public virtual Product Product { get; set; }

        public uint Quantity { get; set; }
        #endregion
    }
}
