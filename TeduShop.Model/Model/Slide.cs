using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Descriptio { get; set; }
        public string Image { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        public bool Status { get; set; }
    }
}