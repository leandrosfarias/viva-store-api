using System.ComponentModel.DataAnnotations;

namespace VivaStoreApi
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        
        public Product() { }

    }
}