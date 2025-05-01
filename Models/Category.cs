using FrontToBackp2.Models.Base;

namespace FrontToBackp2.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
