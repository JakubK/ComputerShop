using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class User
    {
        #region Columns
        [Key]
        public uint ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string PasswordHashed { get; set; }
        #endregion

        public virtual List<Order> Orders { get; set; }

        public virtual ShippingInfo ShippingInfo { get; set; }

        public virtual List<Cart> Carts { get; set; }
    }
}
