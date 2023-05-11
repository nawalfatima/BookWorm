using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Book.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "CoverType")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
