using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Domain.Entites
{
    public class Category
    {
        #region Columns
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        #endregion

        public virtual List<Product> Products { get; set; }
    }
}
