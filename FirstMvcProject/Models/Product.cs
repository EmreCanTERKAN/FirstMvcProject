using System.ComponentModel.DataAnnotations;

namespace FirstMvcProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün Adı Gereklidir.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public decimal Price { get; set; }
    }
}
