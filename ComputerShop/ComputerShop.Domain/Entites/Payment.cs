using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class Payment
    {
        #region Columns
        [Key,ForeignKey("Order")]
        public uint ID { get; set; }
        public virtual Order Order { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Charge { get; set; }

        public bool Paid { get; set; }
        #endregion
    }
}
