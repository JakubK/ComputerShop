using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class Cart
    {
        #region Columns
        [Key]
        public uint ID { get; set; }

        [ForeignKey("User")]
        public uint UserID { get; set; }
        public virtual User User { get; set; }
        #endregion

        public virtual List<CartDetail> CartDetails { get; set; }
    }
}
