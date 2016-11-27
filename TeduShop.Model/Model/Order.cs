using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string CustomeName { get; set; }

        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMoble { get; set; }
        public string CustomerMessage { get; set; }
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool status { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}