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
    [Table("ProductRatings")]
    public class ProductRating
    {
        #region Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [ForeignKey("Product"),Required]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [Range(0,6),Required,DefaultValue(0)]
        public int Rate { get; set; }
        
        [DefaultValue("Brak opisu"),MinLength(0),MaxLength(500)]
        public string Comment { get; set; }

        [ForeignKey("User"),Required]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
