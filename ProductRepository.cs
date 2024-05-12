
using Microsoft.EntityFrameworkCore;

namespace VivaStoreApi
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;
        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task<bool> Add(Product product)
        {
           try 
            { 
                _context.Products.Add(product);
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<bool> DeleteById(int id)
        {
            try
            {
                var product = _context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null) 
                {
                    _context.Products.Remove(product!);
                    _context.SaveChanges();
                } else return Task.FromResult(false);
                
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                Console.WriteLine("Bateu aqui");
                return _context.Products.ToList();
            } 
            catch (Exception)
            {
                throw;
            }
        }

        public Product GetById(int id)
        {
            try
            {
                return _context.Products.FirstOrDefault(x => x.Id == id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> Update(Product product)
        {
            try
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
