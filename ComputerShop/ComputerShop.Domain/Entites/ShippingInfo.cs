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
        public int ID { get; set; }
        public virtual User User { get; set; }
        [Required,MinLength(3),MaxLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Błędny Kod Pocztowy")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Miasto jest wymagane")]
        [MinLength(2),MaxLength(100)]
        public string City { get; set; }

        public int ApartmentNumber { get; set; }
        #endregion
    }
}
