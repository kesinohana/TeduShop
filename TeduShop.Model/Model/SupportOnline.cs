using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Deparment { get; set; }
        public string Skype { get; set; }
        public string Moble { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public bool Status { get; set; }
    }
}