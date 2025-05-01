using FrontToBackp2.Models.Base;

namespace FrontToBackp2.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImageURL { get; set; }
        public bool IsPrime { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
