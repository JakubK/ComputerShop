using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class ProductRating
    {
        #region Columns
        [Key]
        public uint ID { get; set; }
        
        [ForeignKey("Product")]
        public uint ProductID { get; set; }
        public virtual Product Product { get; set; }

        public uint Rate { get; set; }
        
        public string Comment { get; set; }

        [ForeignKey("User")]
        public uint UserID { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
