using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Tamanho máximo é 30 caracteres")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="O número tem que ser entre 1 e 100")]
        public int DisplayOrder { get; set; }
    }
}
