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
    public class ProductState
    {
        #region Columns
        [Key,ForeignKey("Product")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual Product Product { get; set; }

        [Required,DefaultValue(0)]
        public int Quantity { get; set; }

        public bool Available { get; set; }
        #endregion
    }
}
