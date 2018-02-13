using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class Order
    {
        #region Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint ID { get; set; }

        [ForeignKey("User")]
        public uint UserID { get; set; } 
        [MaxLength(20),MinLength(6)]
        public virtual User User { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }
        #endregion

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
