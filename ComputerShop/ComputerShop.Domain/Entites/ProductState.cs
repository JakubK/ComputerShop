using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class ProductState
    {
        #region Columns
        [Key,ForeignKey("Product")]
        public uint ID { get; set; }
        public virtual Product Product { get; set; }

        public uint Quantity { get; set; }

        public bool Available { get; set; }
        #endregion
    }
}
