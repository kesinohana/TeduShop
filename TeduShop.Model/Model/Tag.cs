using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        public virtual IEnumerable<ProductTag> ProductTag { set; get; }
        public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}