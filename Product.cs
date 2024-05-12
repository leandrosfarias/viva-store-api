namespace VivaStoreApi
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Product(int id, string name, string description, int quantityInStock, string category, float price)
        {
            Id = id;
            Name = name;
            Description = description;
            QuantityInStock = quantityInStock;
            Category = category;
            Price = price;
        }


    }
}