﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required,MinLength(3),MaxLength(30)]
        public string PaymentMethod { get; set; }

        [Required, DefaultValue(0)]
        public decimal Charge { get; set; }
        [Required, DefaultValue(0)]
        public decimal Paid { get; set; }
        #endregion
    }
}
