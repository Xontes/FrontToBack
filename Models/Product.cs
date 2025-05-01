using FrontToBackp2.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace FrontToBackp2.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        [Required,MaxLength(100,ErrorMessage ="Description must be maxiumum of 100 elements")]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public List<ProductImage> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
