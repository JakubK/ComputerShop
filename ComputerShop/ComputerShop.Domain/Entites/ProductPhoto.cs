using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class ProductPhoto
    {
        #region Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public string ImageURI { get; set; }
        #endregion

        public virtual Product Product { get; set; }
    }
}
