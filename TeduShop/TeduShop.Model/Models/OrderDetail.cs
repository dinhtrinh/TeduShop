﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
    }
}