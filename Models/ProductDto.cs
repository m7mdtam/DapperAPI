using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ProductDto
    {
        [Required , MaxLength(100)]
        public string Name { get; set; } = "";
        [Required, MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required, MaxLength(100)]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        [ MaxLength(1000)]
        public string Description { get; set; } = "";
    }
}
