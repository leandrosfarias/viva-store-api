using Microsoft.AspNetCore.Mvc;

namespace VivaStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        [HttpGet("{productId}")]
        public Product GetProductByID(int productId)
        {
            return _productService.GetProductById(productId);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            try
            {
                Console.WriteLine("Produto -> " + product.Id);
                await _productService.AddProductAsync(product);
                var productsList = _productService.GetProducts();
                foreach (var item in productsList)
                {
                    Console.WriteLine("item -> " + item);
                }
                return Ok("Produto cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return await Task.FromResult(BadRequest(ex.Message));
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            try
            {
                var result = await _productService.DeleteProductById(id);
                if (result) return Ok("Produto deletado com sucesso.");
                else return BadRequest("Produto não encontrado");
            }
            catch (Exception e)
            {

                //throw;
                Console.WriteLine("Exeception -> " + e);
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutById([FromBody] Product product)
        {
            try
            {
                var result = await _productService.UpdateProduct(product);
                if (result) return Ok("Produto atualizado com sucesso");
                else return BadRequest("Produto não encontrado");
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine("Exeception -> " + e);
                return BadRequest(e.Message);
            }
        }
    }
}