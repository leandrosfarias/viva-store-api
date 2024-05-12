namespace VivaStoreApi
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository= productRepository;
        }

        public async Task<bool> AddProductAsync(Product product)
        {
            return await _productRepository.Add(product);
        }

        public async Task<bool> DeleteProductById(int id)
        {
            return await _productRepository.DeleteById(id);
        }

        public Product GetProductById(int id)
        {
           return _productRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
