namespace VivaStoreApi
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProductById(int id);
        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
