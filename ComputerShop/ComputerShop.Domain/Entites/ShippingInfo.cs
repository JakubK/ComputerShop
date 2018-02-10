using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class ShippingInfo
    {
        #region Columns
        [Key,ForeignKey("User")]
        public uint ID { get; set; }
        public virtual User User { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public uint ApartmentNumber { get; set; }
        #endregion
    }
}
