namespace VivaStoreApi
{
    public interface IProductRepository
    {
        Task<bool> Add(Product product);
        Task<bool> Update(Product product);
        Task<bool> DeleteById(int id);
        List<Product> GetAll();
        Product GetById(int id);
    }
}
