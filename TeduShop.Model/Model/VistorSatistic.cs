using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("VistorStatistics")]
    internal class VistorSatistic
    {
        [Key]
        public int ID { get; set; }

        public DateTime VisitDate { get; set; }
        public string IPAddress { get; set; }
    }
}