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
    public class User
    {
        #region Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,MinLength(2),MaxLength(40)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(40)]
        public string Surname { get; set; }
        [EmailAddress,Required, MinLength(5), MaxLength(40)]
        public string Email { get; set; }

        [Required,DefaultValue("user")]
        public string Role { get; set; }
        
        [Required,StringLength(64)] //64 bo bedziemy raczej uzywac sha 256
        public string PasswordHashed { get; set; }
        #endregion

        public virtual List<Order> Orders { get; set; }

        public virtual ShippingInfo ShippingInfo { get; set; }

        public virtual List<Cart> Carts { get; set; }
    }
}
